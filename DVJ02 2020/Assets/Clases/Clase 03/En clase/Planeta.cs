using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planeta : MonoBehaviour
{
	public Transform sun;
	public float radius = 5;
	float angle = 90;
	public float traslationSpeed = 1;

	public float rotationSpeed = 10;
	public Vector3 rotationVector;
	void Update()
    {
		

		//angle += Time.deltaTime * traslationSpeed;
		//
	    //Vector3 newPos = Vector3.zero;
		//
	    //newPos.x = sun.position.x + radius * Mathf.Cos(angle * Mathf.Deg2Rad);
	    //newPos.z = sun.position.z + radius * Mathf.Sin(angle * Mathf.Deg2Rad);
		//
	    ////newPos += sun.position;
		//
	    //transform.position = newPos;

		transform.Rotate(rotationVector * Time.deltaTime* rotationSpeed);
	}
}
// 1562667575 