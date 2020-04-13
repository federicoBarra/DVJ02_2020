using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace DVJ02.Clase05
{
    public class UIBasisExample : MonoBehaviour
    {

        public Text textObject;

        // Use this for initialization
        private void Start()
        {
            textObject.text = "Texto por programacion";
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