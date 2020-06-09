using DVJ02.Clase10;
using UnityEngine;

namespace DVJ02.Clase12
{
	public class SoundManager : MonoBehaviourSingleton<SoundManager>
	{
		private AudioSource audioSource;
		[Header("Sound Options")]
		public bool soundOn = true;
		public bool musicOn = true;

		public enum SoundType
		{
			CommonButton,
			Help,
			Etc
		}

		public enum MusicType
		{
			Ingame,
			MainMenu,
		}

		public AudioClip[] sfxs;
		public AudioClip[] musics;

		// Use this for initialization
		public override void Awake()
		{
			audioSource = GetComponent<AudioSource>();
			base.Awake();
		}

		public void PlaySound(SoundType st)
		{
			if (!soundOn)
				return;
			AudioSource.PlayClipAtPoint(sfxs[(int)st], Vector3.zero);
		}

		public void PlayMusic(MusicType mt)
		{
			audioSource.clip = musics[(int)mt];
			if (!musicOn)
				return;

			audioSource.Play();
		}

		public void ToggleSound()
		{
			soundOn = !soundOn;

			if (soundOn)
				PlaySound(SoundType.CommonButton);
		}

		public void ToggleMusic()
		{
			musicOn = !musicOn;

			if (musicOn)
				audioSource.Play();
			else
				audioSource.Stop();
		}
	}
}