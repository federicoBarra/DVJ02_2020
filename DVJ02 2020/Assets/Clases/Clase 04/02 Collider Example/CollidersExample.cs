using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DVJ02.Clase04
{
    public class CollidersExample : MonoBehaviour
    {
        private void OnCollisionEnter(Collision collision)
        {
	        if (collision.gameObject.name == "Cube")
		        return;

            Debug.Log(name + " OnCollisionEnter " + collision.gameObject.name);
			Debug.Break();

			Destroy(collision.gameObject);
        }

        private void OnCollisionExit(Collision collisionInfo)
        {
            Debug.Log(name + " OnCollisionExit " + collisionInfo.gameObject.name);
        }

        private void OnCollisionStay(Collision collisionInfo)
        {
            Debug.Log(name + " OnCollisionStay " + collisionInfo.gameObject.name);
        }
    }
}