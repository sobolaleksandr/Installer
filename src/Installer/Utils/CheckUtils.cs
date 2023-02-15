using System.Linq;

using Microsoft.Win32;


namespace Installer.Utils
{
	/// <summary>
	///   Вспомогательные методы для выполнения проверок.
	/// </summary>
	public static class CheckUtils
	{
		/// <summary>
		///   Получить guid продукта текущей версии.
		/// </summary>
		/// <param name="productGuid"> Guid проверяемого продукта. </param>
		/// <returns> Guid продукта, либо null, если продукт не установлен. </returns>
		public static string GetUninstallGuid(string productGuid)
		{
			RegistryKey productKey = GetProductRegistryKey(productGuid);
			string[] nameParts = productKey?.Name.Split('\\');
			return nameParts?.Last();
		}

		/// <summary>
		///   Проверка наличия установленного продукта.
		/// </summary>
		/// <param name="productGuid"> Guid проверяемого продукта. </param>
		/// <returns> True, если продукт установлен. Иначе - false. </returns>
		public static bool HasInstalledProduct(string productGuid)
		{
			RegistryKey productKey = GetProductRegistryKey(productGuid);
			return productKey != null;
		}

		/// <summary>
		///   Получить ключ реестра с guid текущего продукта.
		/// </summary>
		/// <param name="productGuid"> Guid искомого продукта. </param>
		/// <returns> Ключ реестра при его нахождении, иначе - null. </returns>
		private static RegistryKey GetProductRegistryKey(string productGuid)
		{
			try
			{
				RegistryKey localKey = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, RegistryView.Registry64);
				RegistryKey key = localKey.OpenSubKey(@"SOFTWARE\Microsoft\Windows\CurrentVersion\Uninstall") ??
					localKey.OpenSubKey(@"SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Uninstall");

				return key?.GetSubKeyNames()
					.Select(keyName => key.OpenSubKey(keyName))
					.FirstOrDefault(subKey => subKey?.Name.Contains(productGuid) == true);
			}
			catch
			{
				return null;
			}
		}
	}
}