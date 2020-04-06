using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DVJ02.Clase03.EnClase
{
	public class CubeMover : MonoBehaviour
	{
		public float velocidad = 1;
		private Transform pepe;

		void Start()
		{

		}

		void Update()
		{
			float horizontal = Input.GetAxis("Horizontal"); // [-1, 1]
			float vertical = Input.GetAxis("Vertical");

			Vector3 mov = new Vector3(horizontal, 0, vertical);

			transform.position += mov * Time.deltaTime * velocidad;
		}
	}
}