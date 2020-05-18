using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DVJ02.Clase10
{
	public class DecouplingBullet : MonoBehaviour
	{
		[SerializeField]
		private float damage = 10;
		[SerializeField]
		private float bulletForce = 10;

		private Rigidbody rig;

		[SerializeField]
		string bulletEnemyTag = "Enemy"; // "Player"
		// Start is called before the first frame update
		void Awake()
		{
			rig = GetComponent<Rigidbody>();
		}

		public void Shoot(Vector3 direction)
		{
			rig.AddForce(direction * bulletForce, ForceMode.VelocityChange);
		}

		void OnCollisionEnter(Collision collision)
		{
			IDamageable damageable = collision.gameObject.GetComponent<IDamageable>();
			if (damageable != null)
			{
				if (collision.gameObject.CompareTag(bulletEnemyTag))
					Debug.Log("Damageable: " + collision.gameObject.name);
				damageable.GetDamage(damage);
			}

			Destroy(gameObject);
		}
	}
}
