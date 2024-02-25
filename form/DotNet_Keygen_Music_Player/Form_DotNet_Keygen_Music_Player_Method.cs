namespace DotNet_Keygen_Music_Player
{
	partial class Form_DotNet_Keygen_Music_Player
	{
		public Form_DotNet_Keygen_Music_Player Init(string[] args)
		{
			currentDirectory = Directory.GetCurrentDirectory();
			musicManager.OnLoad();
			if (args.Length == 0)
			{
				Console.WriteLine($"No music file from arguments.");
				musicManager.ResetMusic(this);
			}
			else
			{
				var filePath = args[0];
				musicManager.OpenMusic(filePath);
				Console.WriteLine($"Opened music file from arguments: {filePath}");
			}
			Console.WriteLine($"Playing music: {musicManager.musicName}");
			return this;
		}
	}
}
