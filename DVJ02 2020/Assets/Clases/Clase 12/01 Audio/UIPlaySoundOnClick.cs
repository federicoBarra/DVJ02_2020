using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace DVJ02.Clase12
{
	public class UIPlaySoundOnClick : MonoBehaviour
	{
		private Button button;
		public SoundManager.SoundType sound;
		// Use this for initialization
		private void Awake()
		{
			button = GetComponent<Button>();
			button.onClick.AddListener(OnClick);
		}

		public void OnClick()
		{
			SoundManager.Get().PlaySound(sound);
		}

	}
}
