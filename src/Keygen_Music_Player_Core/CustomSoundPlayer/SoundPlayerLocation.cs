using System.Media;

namespace Keygen_Music_Player.CustomSoundPlayer
{
	internal class SoundPlayerLocation : ISoundPlayer
	{
		private SoundPlayer soundPlayerLocation;

		public void Init()
		{
			
		}

		public void Load(Stream music)
		{
			
		}

		public void Load(string musicLocation)
		{
			if (soundPlayerLocation == null)
			{
				soundPlayerLocation = new SoundPlayer(musicLocation);
			}
			else
			{
				soundPlayerLocation.SoundLocation = musicLocation;
			}
		}

		public void Play()
		{
			soundPlayerLocation.PlayLooping();
		}

		public void Stop()
		{
			soundPlayerLocation.Stop();
		}
	}
}
