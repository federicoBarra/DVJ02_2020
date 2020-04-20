using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace DVJ02.Clase05
{
    public class UIBasisExample : MonoBehaviour
    {
        public Text textObject;
	    public int numero = 500000;
	    public int numero02;

		// Use this for initialization
		private void Start()
        {
	        Text[] texts = FindObjectsOfType<Text>();

			textObject.text = numero.ToString("G");

			Debug.Log("Hola que tal: " + numero);

        }

        // Update is called once per frame
        private void Update()
        {
		}

        public void ButtonPressed()
        {
            Debug.Log("Button pressed");
        }

    }

}