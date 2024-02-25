namespace Keygen_Music_Player.CustomSoundPlayer
{
	internal interface ISoundPlayer
	{
		public void Init();

		public void Load(Stream music);

		public void Load(string musicLocation);

		public void Play();

		public void Stop();
	}
}
