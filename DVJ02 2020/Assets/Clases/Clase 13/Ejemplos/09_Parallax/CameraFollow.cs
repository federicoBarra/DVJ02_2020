using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DVJ02.Clase13
{
	public class CameraFollow : MonoBehaviour
	{
		public Transform target;
		public Vector3 distance;
		public float camSpeed = 10;
		public AnimationCurve bulletTime;
		private void LateUpdate()
		{
			transform.position = Vector3.Slerp(transform.position, target.position + distance, camSpeed * Time.deltaTime);

			Time.timeScale = 0;
			//transform.position = target.position + distance;
		}

		//corutina
		//Time.timeScale = bulletTime.Evaluate(t);

		//f(x) = sin(x)

		//x = 0 - pi

		//f(x) = 0 - 1
			
	}
}
