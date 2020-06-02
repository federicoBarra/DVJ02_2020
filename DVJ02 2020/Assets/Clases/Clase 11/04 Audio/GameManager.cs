using UnityEngine;

namespace DVJ02.Clase11
{
	public class GameManager : MonoBehaviour
	{
		SoundManager soundManager;

		// Use this for initialization
		private void Start()
		{
			soundManager = SoundManager.Get();
			soundManager.soundOn = PlayerProfile.GetSoundOn();
			soundManager.musicOn = PlayerProfile.GetMusicOn();
			soundManager.PlayMusic(SoundManager.MusicType.Ingame);
		}

		void OnDestroy()
		{
			PlayerProfile.SaveSound(soundManager.musicOn, soundManager.soundOn);
		}
	}
}