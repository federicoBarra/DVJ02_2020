using UnityEngine;

namespace DVJ02.Clase13
{
	public class BackgroundParallax : MonoBehaviour
	{
		[System.Serializable]
		public class ParallaxLayer
		{
			public GameObject layer;
			public float moveCameraRatio = 0;
			public float moveCameraRatioY = 0;
		}

		public ParallaxLayer[] layers;

		float lastCamXPos;

		void LateUpdate()
		{
			float mainCamPos = Camera.main.transform.position.x;
			float deltaCamX = lastCamXPos - mainCamPos;

			foreach (ParallaxLayer layer in layers)
			{
				layer.layer.transform.position += Vector3.right * deltaCamX * layer.moveCameraRatio;
				layer.layer.transform.position += Vector3.up * deltaCamX * layer.moveCameraRatioY;
			}

			lastCamXPos = mainCamPos;
		}
	}
}