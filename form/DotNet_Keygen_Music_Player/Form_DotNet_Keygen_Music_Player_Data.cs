using Keygen_Music_Player;

namespace DotNet_Keygen_Music_Player
{
	partial class Form_DotNet_Keygen_Music_Player
	{
		private string currentDirectory { get; set; }

		private MusicManager musicManager { get; } = new MusicManager();

		internal partial class MusicManager
		{
			internal static Stream defaultMusic = new MemoryStream(Properties.Resources.keygen_music);

			internal static string defaultMusicDirectory { get; } = "music";

			internal static string defaultMusicName { get; } = "toilet4.xm";

			private MusicSystem musicSystem { get; } = new MusicSystem();

			internal string musicPath { get; set; }

			internal string musicDirectory { get; set; }

			internal string musicName { get; set; }

			internal string musicExtension { get; set; }
		}
	}
}
