using System.Windows.Forms;

using Installer.Constants;
using Installer.Dialogs;

using WixSharp;


namespace Installer.Utils
{
	/// <summary>
	///   События установщика.
	/// </summary>
	internal static class InstallEvents
	{
		/// <summary>
		///   Проверка необходимости удаления продукта.
		/// </summary>
		public static void CheckUninstallNecessity(SetupEventArgs e)
		{
			e.ManagedUI.SetSize(600, 450);
			bool hasInstalledProduct = CheckUtils.HasInstalledProduct(ApplicationSettings.StartGuidValue);
			if (!hasInstalledProduct)
				e.ManagedUI.Shell.Dialogs.Remove(typeof(UninstallDialog));
		}

		/// <summary>
		///   MessageBox с ошибкой.
		/// </summary>
		/// <param name="message"> Текст сообщения. </param>
		public static void ShowError(string message)
		{
			MessageBox.Show(message, @"Ошибка установки", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}
	}
}