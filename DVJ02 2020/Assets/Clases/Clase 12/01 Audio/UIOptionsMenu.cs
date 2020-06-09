using UnityEngine;
using UnityEngine.UI;

namespace DVJ02.Clase12
{
	public class UIOptionsMenu : MonoBehaviour
	{
		public Toggle sound;
		public Toggle music;
		public GameObject soundPanel;

		//Ver Script Execution Order
		private void Start()
		{
			sound.SetIsOnWithoutNotify(SoundManager.Get().soundOn);
			music.SetIsOnWithoutNotify(SoundManager.Get().musicOn);
		}

		public void SoundToggled()
		{
			SoundManager.Get().ToggleSound();
		}

		public void MusicToggled()
		{
			SoundManager.Get().ToggleMusic();
		}

		public void TestSound()
		{
			SoundManager.Get().PlaySound(SoundManager.SoundType.CommonButton);
		}

		public void OpenCloseSoundOptions()
		{
			soundPanel.SetActive(!soundPanel.activeInHierarchy);
		}
	}
}
