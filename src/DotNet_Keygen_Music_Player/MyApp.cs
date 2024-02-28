namespace DotNet_Keygen_Music_Player
{
	internal static class MyApp
	{
		[STAThread]
		static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form_DotNet_Keygen_Music_Player().Init(args));
		}
	}
}
