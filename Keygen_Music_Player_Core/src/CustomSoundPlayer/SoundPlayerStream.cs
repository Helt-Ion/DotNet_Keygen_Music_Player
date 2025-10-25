using System.Media;

namespace Keygen_Music_Player.CustomSoundPlayer
{
	internal class SoundPlayerStream : ISoundPlayer
	{
		private SoundPlayer soundPlayerStream;

		public void Init()
		{

		}

		public void Load(Stream music)
		{
			if (soundPlayerStream == null)
			{
				soundPlayerStream = new SoundPlayer(music);
			}
			else
			{
				soundPlayerStream.Stream = music;
			}
		}

		public void Load(string musicLocation)
		{

		}

		public void Play()
		{
			soundPlayerStream.PlayLooping();
		}

		public void Stop()
		{
			soundPlayerStream.Stop();
		}
	}
}
