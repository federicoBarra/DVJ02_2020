using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DVJ02.Clase04
{
    public class TriggerExample : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            Debug.Log(name + " OnTriggerEnter " + other.gameObject.name);
        }

        private void OnTriggerExit(Collider other)
        {
            Debug.Log(name + " OnTriggerExit " + other.gameObject.name);
        }

        private void OnTriggerStay(Collider other)
        {
            Debug.Log(name + " OnTriggerStay " + other.gameObject.name);
        }
    }
}
