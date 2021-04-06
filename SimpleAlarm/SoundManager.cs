using System.Media;

namespace SimpleAlarm
{
	public class SoundManager
	{
		private SoundPlayer soundPlayer;

		public SoundManager() => soundPlayer = new SoundPlayer();

		public void Set(string path) => soundPlayer.SoundLocation = path;

		public void PlayMusic() => soundPlayer.Play();

		public void StopMusic() => soundPlayer.Stop();

		public void PlayLooping() => soundPlayer.PlayLooping();
	}
}
