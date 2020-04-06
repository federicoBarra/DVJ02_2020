﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DVJ02.Clase04
{
    public class RigidbodiesExample : MonoBehaviour
    {
        private Rigidbody rig;
        public float force = 10;
	    public Vector3 direction;

        private void Start()
        {
            rig = GetComponent<Rigidbody>();
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Space))
                rig.AddForce(direction * force);
        }
    }
}
