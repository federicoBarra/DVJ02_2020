using UnityEngine;

namespace DVJ02.Clase11
{
	public class UILoadNextLevel : MonoBehaviour
	{
		public void LoadNextLevel()
		{
			LoaderManager.Get().LoadScene("Loader 02");
			UILoadingScreen.Get().SetVisible(true);
		}

	}
}