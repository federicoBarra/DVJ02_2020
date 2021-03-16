using UnityEngine;

public class DiezItem : MonoBehaviour
{
	public GameObject trigger;
	public LayerMask playersLayer;

	[SerializeField] //solo debug
	private GameObject thrower;
	[SerializeField] //solo debug
	private bool doingDamage;

	private RaycastHit[] raycastHits;

	private Rigidbody rig;
	void Awake()
	{
		rig = GetComponent<Rigidbody>();
	}
	Collider[] hitColliders = new Collider[20];

	void Update()
	{
		if (!doingDamage)
			return;
		
		int numColliders = Physics.OverlapSphereNonAlloc(transform.position, 1, hitColliders, playersLayer);
		for (int i = 0; i < numColliders; i++)
		{
			if (hitColliders[i].transform.gameObject != thrower)
			{
				DoDamage(hitColliders[i].transform.gameObject);
			}
		}
	}

	void DoDamage(GameObject go)
	{
		Debug.Log("Do Damage To: " + go.name);
		rig.velocity = Vector3.zero;
		rig.AddForce(Vector3.up);
		go.GetComponent<DiezController>().TakeDamage(Vector3.zero);
		doingDamage = false;
		thrower = null;
		SetPickapeable(true);
	}

	public void SetPickapeable(bool b)
	{
		trigger.SetActive(b);
	}

	public void Throw(Vector3 dir, GameObject _thrower)
	{
		Debug.Log("THROW by: " + _thrower.name);
		rig.MovePosition(transform.position + Vector3.up);
		rig.AddForce(dir);
		thrower = _thrower;
		doingDamage = true;
	}

	void OnCollisionEnter(Collision collision)
	{
		doingDamage = false;
		SetPickapeable(true);
	}

}
