using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DVJ02.Clase05
{
    public class LayeredCollition : MonoBehaviour
    {
        public LayerMask layerMask; //Esto es una mascara bitwise basicamente.
        //https://www.tutorialspoint.com/csharp/csharp_bitwise_operators.htm

        public int checkAgainstLayer;

        // Use this for initialization
        private void Start()
        {
            checkAgainstLayer = LayerMask.NameToLayer("Esferas01");
        }

        private void OnCollisionEnter(Collision collision)
        {
            string layerName = LayerMask.LayerToName(collision.gameObject.layer);

            bool contiene = Contains(layerMask, collision.gameObject.layer);
            if (contiene)
            {
                Debug.Log("Colisiono con una layer contenida en layerMask (GameObject: " + collision.gameObject.name +
                          ")");
            }
            else
            {
                Debug.Log("Colisiono con una layer NO contenida en layerMask (GameObject: " + collision.gameObject.name +
                          ")");
            }

            Debug.Log("Colisiono con la layer: " + layerName + " del GameObject: " + collision.gameObject.name + ")");
        }

        public bool Contains(LayerMask mask, int layer)
        {
            return mask == (mask | (1 << layer));
        }

    }
}
