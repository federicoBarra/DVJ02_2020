using DVJ02.Clase10;
using UnityEngine;

namespace DVJ02.Clase12
{
	public class PlayerProfile
	{
		public static void SaveSound(bool music, bool sound)
		{
			PlayerPrefs.SetInt("SoundOn", sound ? 1 : 0);
			PlayerPrefs.SetInt("MusicOn", music ? 1 : 0);
		}

		public static bool GetSoundOn()
		{
			if (PlayerPrefs.HasKey("SoundOn"))
				return PlayerPrefs.GetInt("SoundOn") == 1;
			return true;
		}

		public static bool GetMusicOn()
		{
			if (PlayerPrefs.HasKey("MusicOn"))
				return PlayerPrefs.GetInt("MusicOn") == 1;
			return true;
		}
	}
}