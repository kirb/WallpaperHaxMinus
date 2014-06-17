using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WallpaperHaxPlus;

namespace WallpaperHaxMinus
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

            Registry.SetValue("HKEY_CURRENT_USER\\Software\\PCHax Technology\\WallpaperHaxMinus", "LastVersion", 1, RegistryValueKind.DWord);
            Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Run", "WallpaperHaxMinus", Process.GetCurrentProcess().MainModule.FileName);

			Application.Run(new WallpaperHaxPlus.WallpaperForm());
		}
	}
}
