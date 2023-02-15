using System;
using System.Diagnostics;

using Installer.Constants;
using Installer.Utils;

using WixSharp.UI.Forms;


namespace Installer.Dialogs
{
	/// <summary>
	///   Диалог деинсталляции.
	/// </summary>
	public partial class UninstallDialog : ManagedForm
	{
		/// <summary>
		///   Инициализация.
		/// </summary>
		public UninstallDialog()
		{
			InitializeComponent();
			Load += (sender, args) =>
				image.Image = MsiRuntime.GetMsiBitmap("WixUI_Bmp_Dialog");
		}

		/// <summary>
		///   Отменить деинсталляцию.
		/// </summary>
		private void Cancel(object sender, EventArgs e)
		{
			Shell.Cancel();
		}

		/// <summary>
		///   Выполнить деинсталляцию.
		/// </summary>
		private void Delete(object sender, EventArgs e)
		{
			string productKey = CheckUtils.GetUninstallGuid(ApplicationSettings.StartGuidValue) ??
				MsiRuntime.ProductCode;

			Process progress = Process.Start($"{MsiRuntime.Session["System64Folder"]}msiexec.exe",
				$"/x {productKey} /qr");

			progress?.WaitForExit();

			int currentDialogIndex = Shell.Dialogs.IndexOf(GetType());
			if (Shell.Dialogs.Count == currentDialogIndex + 1)
				Shell.Exit();
			else
				Shell.GoNext();
		}
	}
}