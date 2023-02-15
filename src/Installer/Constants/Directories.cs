using System;


namespace Installer.Constants
{
	/// <summary>
	///   Имена директорий и файлов.
	/// </summary>
	public static class Directories
	{
		/// <summary>
		///   Путь к директории сборки.
		/// </summary>
		public const string BuildPath = @"..\..\Installer\Builds";

		/// <summary>
		///   Путь до данных.
		/// </summary>
		public const string DataPath = @"..\..\Data\";

		/// <summary>
		///   Общий путь к dll файлам.
		/// </summary>
		public const string DllCommonPath = @"..\..\bin\Release\";

		/// <summary>
		///   Адрес стартового меню.
		/// </summary>
		public const string StartMenu = @"Microsoft\Windows\Start Menu\Programs";

		/// <summary>
		///   Путь до папки общих данных.
		/// </summary>
		public static string CommonApplicationData { get; } = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData);
	}
}