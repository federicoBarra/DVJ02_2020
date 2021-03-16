using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiezController : MonoBehaviour
{
	public float throwStreght = 10;
	public DiezObjectPicker picker;
	public ParticleSystem ps;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
			Hit();

	    if (Input.GetKeyDown(KeyCode.Space))
			Interact();
	}

	void Hit()
	{
		//sphereCast 
		//get enemy
		//do Damage
	}

	void Interact()
	{
		if (picker.HasObjectAround())
			picker.PickItem();
		else
			picker.Throw(Vector3.right * throwStreght, thrower:gameObject);
	}

	public void TakeDamage(Vector3 hitPos)
	{
		ps.Play();
		//do something with hitpos
	}
}
