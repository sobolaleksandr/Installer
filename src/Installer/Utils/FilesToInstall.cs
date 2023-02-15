using System.Collections.Generic;

using Installer.Constants;

using WixSharp;


namespace Installer.Utils
{
	/// <summary>
	///   Класс для формирования всех необходимых для установки файлов.
	/// </summary>
	public static class FilesToInstall
	{
		/// <summary>
		///   Получить директории с файлами установки.
		/// </summary>
		/// <returns> Список директорий. </returns>
		public static List<Dir> Get()
		{
			string productPath = $@"{ApplicationSettings.CompanyName}\{ApplicationSettings.ProductName}";

			// папка с dll-файлами плагина
			const string dllCommonPath = Directories.DllCommonPath;
			// папка Data
			const string dataPath = Directories.DataPath;
			const string projectName = ApplicationSettings.ProjectName;

			var installDir = new Dir($@"{Directories.CommonApplicationData}\Applications\{productPath}") { IsInstallDir = true };
			var commonPathDir = new Dir($@"Applications\{productPath}"
				//new File($"{dllCommonPath}{projectName}.dll"),
				//new File($"{dllCommonPath}Emgu.CV.Platform.NetStandard.dll"),
				//new File($"{dllCommonPath}ExifLib.dll"),
				//new File($"{dllCommonPath}Microsoft.WindowsAPICodePack.dll"),
				//new File($"{dllCommonPath}Microsoft.WindowsAPICodePack.Shell.dll"),
				//new File($"{dllCommonPath}Microsoft.WindowsAPICodePack.ShellExtensions.dll"),
				//new File($"{dllCommonPath}RoadAnalysis.UI.exe",
				//	new FileShortcut("Анализ дорожного покрытия", @"%Desktop%")),
				//new File(@"..\..\Installer\Лог изменений.txt"),
				//new Dir("x64", new Files($@"{dllCommonPath}x64\*.dll")),
				//new Dir("x86", new Files($@"{dllCommonPath}x86\*.dll")),
				//new Dir(@"Data",
				//	new Dir(@"EqualImages\Template",
				//		new Dir(@"Road", new Files($@"{dataPath}EqualImages\Template\Road\*.JPG")),
				//		new Dir(@"Roadside", new Files($@"{dataPath}EqualImages\Template\Roadside\*.JPG")),
				//		new Dir(@"RoadWithRoadside", new Files($@"{dataPath}EqualImages\Template\Roadside\*.JPG"))
				//	)
				//)
			);

			var startMenuDir = new Dir(
				$@"{Directories.StartMenu}\{ApplicationSettings.ProductName}\",
				new ExeFileShortcut(
					$"Удаление {ApplicationSettings.ProductName}",
					"[System64Folder]msiexec.exe",
					"/x [ProductCode]"),
				new ExeFileShortcut(
					$"{ApplicationSettings.ProductName}",
					"[INSTALLDIR]RoadAnalysis.UI.exe",
					"")
			);

			return new List<Dir>
			{
				installDir,
				new Dir(Directories.CommonApplicationData, commonPathDir, startMenuDir)
			};
		}
	}
}