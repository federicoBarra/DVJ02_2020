using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DVJ02.Clase03.EnClase
{
	public class MiScript : MonoBehaviour
	{
		public int Pepe;

		public int[] arrayDeInts;
		public List<int> listaDeInts;
		public List<string> listaDeString;

		public Auto auto01;
		public Auto auto02;

		public float upSpeed = 5;

		void Awake()
		{
			Debug.Log("awake");
		}

		void OnEnable()
		{
			Debug.Log("OnEnabled");
			Debug.Log(auto01.Velocidad);
			Debug.Log(auto02.Velocidad);
		}

		void OnDisable()
		{
			Debug.Log("OnDisabled");
		}

		// Start is called before the first frame update
		void Start()
		{
			listaDeInts.Add(78);

			listaDeInts.RemoveAt(0);

			transform.position += Vector3.up;

			//Debug.Log("Usando For");
			//for (int i = 0; i < listaDeInts.Count; i++)
			//{
			//    int arrayDeInt = listaDeInts[i];
			//    Debug.Log(arrayDeInt);
			//}
			//
			//Debug.Log("Usando Foreach");
			//foreach (int arrayDeInt in arrayDeInts)
			//{
			//	Debug.Log(arrayDeInt);
			//}

		}

		// Update is called once per frame
		void Update()
		{
			transform.position += Vector3.up * Time.deltaTime * upSpeed;
			//Debug.Log("Update");
		}

		void FixedUpdate()
		{
			//Debug.Log("FixedUpdate");
		}

		void OnDeath()
		{
			//score + 10
		}
	}
}