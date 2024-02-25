using Keygen_Music_Player.CustomSoundPlayer;

namespace Keygen_Music_Player
{
	public class MusicSystem
	{
		public enum MusicType
		{
			None,
			WAV,
			MOD
		};

		private MusicType musicType { get; set; } = MusicType.None;

		private ISoundPlayer soundPlayer { get; set; } = new SoundPlayerNull();

		private ISoundPlayer soundPlayerStream { get; set; } = new SoundPlayerStream();

		private ISoundPlayer soundPlayerLocation { get; set; } = new SoundPlayerLocation();

		private ISoundPlayer soundPlayerMikMod { get; set; } = new SoundPlayerMikMod();

		private bool isPlaying { get; set; } = false;

		private MusicType GetMusicType(string extension)
		{
			return extension.ToLower() switch
			{
				".wav" => MusicType.WAV,
				".mod" => MusicType.MOD,
				".m15" => MusicType.MOD,
				".669" => MusicType.MOD,
				".xm" => MusicType.MOD,
				".it" => MusicType.MOD,
				".s3m" => MusicType.MOD,
				".far" => MusicType.MOD,
				".ult" => MusicType.MOD,
				".mtm" => MusicType.MOD,
				_ => MusicType.None
			};
		}
		
		private void SetSoundPlayer(Stream music)
		{
			soundPlayerStream.Load(music);
			soundPlayer = soundPlayerStream;
		}

		private void SetSoundPlayer(string musicLocation)
		{
			soundPlayerLocation.Load(musicLocation);
			soundPlayer = soundPlayerLocation;
		}

		private void SetMikMod(Stream music)
		{
			soundPlayerMikMod.Load(music);
			soundPlayer = soundPlayerMikMod;
		}

		private void SetMikMod(string musicLocation)
		{
			soundPlayerMikMod.Load(musicLocation);
			soundPlayer = soundPlayerMikMod;
		}

		public void OnLoad()
		{
			soundPlayerStream.Init();
			soundPlayerLocation.Init();
			soundPlayerMikMod.Init();
		}

		public void Play()
		{
			if (!isPlaying)
			{
				soundPlayer.Play();
				isPlaying = true;
			}
		}

		public void Stop()
		{
			if (isPlaying)
			{
				soundPlayer.Stop();
				isPlaying = false;
			}
		}

		public void Init(Stream music, string extension)
		{
			musicType = GetMusicType(extension);
			Stop();
			switch (musicType)
			{
				case MusicType.None:
					Console.WriteLine($"Warning: format {extension} not supported!");
                    return;
                case MusicType.WAV:
					SetSoundPlayer(music);
					break;
				case MusicType.MOD:
					SetMikMod(music);
					break;
			}
			Play();
		}

		public void Init(string musicLocation, string extension)
		{
			musicType = GetMusicType(extension);
			Stop();
			switch (musicType)
			{
				case MusicType.None:
					Console.WriteLine($"Warning: format {extension} not supported!");
					return;
				case MusicType.WAV:
					SetSoundPlayer(musicLocation);
					break;
				case MusicType.MOD:
					SetMikMod(musicLocation);
					break;
			}
			Play();
		}
	}
}
