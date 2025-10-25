namespace DotNet_Keygen_Music_Player
{
	partial class Form_DotNet_Keygen_Music_Player
	{
		partial class MusicManager
		{
			private void GetMusicData(string filePath)
			{
				musicPath = filePath;
				musicDirectory = Path.GetDirectoryName(musicPath);
				musicName = Path.GetFileName(musicPath);
				musicExtension = Path.GetExtension(musicPath);
			}

			internal void OnLoad()
			{
				Console.WriteLine($"Loaded Music System.");
				musicSystem.OnLoad();
			}

			internal void OpenMusic(string filePath)
			{
				GetMusicData(filePath);
				musicSystem.Init(musicPath, musicExtension);
			}

			internal void OpenMusicDialog()
			{
				using (var openFileDialog = new OpenFileDialog())
				{
					openFileDialog.InitialDirectory = musicDirectory;
					openFileDialog.Filter = "Supported Music Files|*.wav;*.mod;*.m15;*.669;*.xm;*.it;*.s3m;*.far;*.ult;*.mtm;|Mod Files|*.mod;*.m15;*.669;*.xm;*.it;*.s3m;*.far;*.ult;*.mtm;|Wav Files|*.wav|All files (*.*)|*.*";
					openFileDialog.FilterIndex = 1;

					if (openFileDialog.ShowDialog() == DialogResult.OK)
					{
						// Get the path of specified file
						var filePath = openFileDialog.FileName;

						// Open the music
						OpenMusic(filePath);

						Console.WriteLine($"Playing music: {musicName}");
					}
					else
					{
						Console.WriteLine($"Operation cancelled.");
					}
				}
			}

			internal void ResetMusic(Form_DotNet_Keygen_Music_Player formKeygenMusic)
			{
				GetMusicData(Path.Join(formKeygenMusic.currentDirectory, defaultMusicDirectory, defaultMusicName));
				musicSystem.Init(defaultMusic, musicExtension);
			}

			internal void PlayMusic()
			{
				musicSystem.Play();
			}

			internal void StopMusic()
			{
				musicSystem.Stop();
			}
		}
	}
}
