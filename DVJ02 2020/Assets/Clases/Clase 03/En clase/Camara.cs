using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

namespace DVJ02.Clase03.EnClase
{
	public class Camara : MonoBehaviour
	{
		public float cadaCuantoCambioDePlaneta = 5;
		public float timer;

		public GameObject[] planetas;

		// indice de planeta actual
		private int planetaActual = 0;
		public Vector3 offset;
		public float camVelocity;


		void Start()
		{

		}

		void LateUpdate()
		{
			timer += Time.deltaTime;

			if (timer > cadaCuantoCambioDePlaneta)
			{
				planetaActual++;

				//if (planetaActual >= planetas.Length)
				//    planetaActual = 0;

				planetaActual = planetaActual % planetas.Length;
				// 0 % 3 = 0
				// 1 % 3 = 1
				// 2 % 3 = 2
				// 3 % 3 = 0
				timer = 0;
			}

			Vector3 newPos = planetas[planetaActual].transform.position + offset;

			Vector3 currentPos = transform.position;

			Vector3 direction = newPos - currentPos;

			direction = direction.normalized;


			if (Vector3.Distance(currentPos, newPos) > 2)
				transform.position += direction * Time.deltaTime * camVelocity;
		}
	}
}