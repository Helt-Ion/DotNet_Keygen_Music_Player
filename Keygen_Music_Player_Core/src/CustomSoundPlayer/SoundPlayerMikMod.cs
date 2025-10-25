using SharpMik.Player;
using SharpMik;

namespace Keygen_Music_Player.CustomSoundPlayer
{
	internal class SoundPlayerMikMod : ISoundPlayer
	{
		private MikMod mikMod { get; set; }

		private Module mikModule { get; set; }

		public void Init()
		{
			// Init mikMod
			ModDriver.Mode = (ushort)(ModDriver.Mode | SharpMikCommon.DMODE_NOISEREDUCTION);
			mikMod = new MikMod();
			mikMod.Init<AudioDriver>();
			mikMod.PlayerStateChangeEvent += (ModPlayer.PlayerState state) =>
			{
				if (state == ModPlayer.PlayerState.kStopped)
				{
					mikMod.Play(mikModule);
					mikMod.SetPosition(0);
				}
			};
		}

		public void Load(Stream music)
		{
			mikModule = mikMod.LoadModule(music);
		}

		public void Load(string musicLocation)
		{
			mikModule = mikMod.LoadModule(musicLocation);
		}

		public void Play()
		{
			mikMod.Play(mikModule);
			mikMod.SetPosition(0);
		}

		public void Stop()
		{
			mikMod.Stop();
		}
	}
}
