using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace DVJ02.Clase05
{
    public class SceneManagementExample : MonoBehaviour
    {
	    public Text buttonText;

        // Use this for initialization
        private void Start()
        {

        }

        // Update is called once per frame
        private void Update()
        {

        }

        public void LoadScene()
        {
            //La escena necesita estar agregada a las Build Settings
            SceneManager.LoadScene("SceneManagementExample 02");
        }

    }
}
