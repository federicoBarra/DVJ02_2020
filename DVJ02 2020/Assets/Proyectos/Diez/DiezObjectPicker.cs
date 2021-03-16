using UnityEngine;

public class DiezObjectPicker : MonoBehaviour
{
	public GameObject objectAround;
	public DiezItem objectPicked;

	public bool HasObjectAround()
	{
		return objectAround != null;
	}

	public void PickItem()
	{
		if (objectAround)
		{
			objectPicked = objectAround.GetComponent<DiezItem>();
			objectPicked.SetPickapeable(false);
		}

		objectAround = null;
	}

	public void Throw(Vector3 direction, GameObject thrower)
	{
		if (!objectPicked)
			return;

		objectPicked.Throw(direction, thrower);
		objectPicked = null;
	}

	private void OnTriggerEnter(Collider other)
	{
		//Debug.Log("Enter other: " + other.name);
		if (other.tag == "pick")
			objectAround = other.gameObject.transform.parent.gameObject;
	}

	private void OnTriggerExit(Collider other)
	{
		//Debug.Log("Exit other: " + other.name);
		if (other.tag == "pick" && objectAround == other.gameObject.transform.parent.gameObject)
			objectAround = null;
	}

	void OnDrawGizmos()
	{
		if (objectAround)
		{
			Gizmos.color = Color.yellow;
			Gizmos.DrawSphere(objectAround.transform.position, 1);
		}
	}
}
