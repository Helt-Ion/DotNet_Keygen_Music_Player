using System.Runtime.InteropServices;

namespace DotNet_Keygen_Music_Player
{
	internal static class Utils
	{
		[DllImport("kernel32.dll")]
		static extern IntPtr GetConsoleWindow();

		[DllImport("user32.dll")]
		static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

		const int SW_HIDE = 0;
		const int SW_SHOW = 5;

		public static void HideConsole()
		{
			var handle = GetConsoleWindow();
			ShowWindow(handle, SW_HIDE);
		}

		public static void ShowConsole()
		{
			var handle = GetConsoleWindow();
			ShowWindow(handle, SW_SHOW);
		}

		public static void HideConsolebySetting()
		{
			if (Properties.Settings.Default.Show_Console)
			{
				ShowConsole();
			}
			else
			{
				HideConsole();
			}
		}
	}
}
