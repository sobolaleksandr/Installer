using System;
using System.IO;
using System.Linq;

using Installer.Constants;
using Installer.Dialogs;
using Installer.Utils;

using WixSharp;
using WixSharp.UI.Forms;


namespace Installer
{
	/// <summary>
	///   Класс создания файла msi.
	/// </summary>
	internal class Program
	{
		/// <summary>
		///   Точка входа программы.
		/// </summary>
		/// <param name="args"> Аргументы. </param>
		public static void Main(string[] args)
		{
			try
			{
				string version = GetVersion();

				var project = new ManagedProject(ApplicationSettings.ProductName)
				{
					Version = new Version(version),
					Platform = Platform.x64,
					GUID = new Guid(ApplicationSettings.Guid),
					DefaultFeature = { Display = FeatureDisplay.hidden },
					BackgroundImage = @"images\background.png",
					BannerImage = @"images\banner.png",
					LocalizationFile = @"localization\localization.wxl",
					Language = "Ru-ru",
					MajorUpgrade = new MajorUpgrade
					{
						IgnoreRemoveFailure = false,
						AllowDowngrades = true
					},
					ControlPanelInfo = new ProductInfo
					{
						Manufacturer = ApplicationSettings.CompanyName
					},
					InstallScope = InstallScope.perMachine
				};

				project.Dirs = FilesToInstall.Get().ToArray();

				SetUI(project);
				project.UIInitialized += InstallEvents.CheckUninstallNecessity;

				//TODO: вернуть, если возникает ошибка
				//Compiler.WixLocation = @"..\..\packages\WixSharp.wix.bin.3.11.0\tools\bin";

				string path = GetDirectoryBuildPath();
				string msiName = $@"{ApplicationSettings.BuildName}_{version}.msi";

				project.BuildMsi(Path.Combine(path, msiName));
			}
			catch (Exception exception)
			{
				InstallEvents.ShowError(exception.Message);
			}
		}

		/// <summary>
		///   Возвращает дату в виде строки для версии продукта.
		/// </summary>
		/// <param name="date"> Дата. </param>
		private static string GetDateString(int date) => date < 10 ? $"0{date}" : $"{date}";

		/// <summary>
		///   Возвращает директорию для сборки.
		/// </summary>
		/// <returns> Директория сборки. </returns>
		private static string GetDirectoryBuildPath()
		{
			if (!Directory.Exists(Directories.BuildPath))
				return Directories.BuildPath;

			var directoryInfo = new DirectoryInfo(Directories.BuildPath);
			DirectoryInfo[] directories = directoryInfo.GetDirectories();

			return directories.Any() != true
				? Directories.BuildPath
				: directories.First().FullName;
		}

		/// <summary>
		///   Возвращает версию продукта.
		/// </summary>
		private static string GetVersion()
		{
			DateTime date = DateTime.Now;
			string dateVersion =
				$"{GetDateString(date.Month)}{GetDateString(date.Day)}{GetDateString(date.Hour)}{GetDateString(date.Minute)}";

			return $"1.0.0.{dateVersion}";
		}

		/// <summary>
		///   Создание управляемого UI.
		/// </summary>
		/// <param name="project"> Проект инсталлятора. </param>
		// ReSharper disable once InconsistentNaming
		private static void SetUI(ManagedProject project)
		{
			project.ManagedUI = new ManagedUI();

			project.ManagedUI.InstallDialogs
				.Add<UninstallDialog>()
				.Add<WelcomeDialog>()
				.Add<ProgressDialog>()
				.Add<ExitDialog>();

			project.ManagedUI.ModifyDialogs.Add<UninstallDialog>();
		}
	}
}