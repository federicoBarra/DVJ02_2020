using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DVJ02.Clase10
{
	public class DecouplingEnemy : MonoBehaviour, IDamageable
	{
		[SerializeField]
		private float health = 25;

		public void GetDamage(float damage)
		{
			health -= damage;
			if (health<0)
				Die();
		}

		public void Die()
		{
			Destroy(gameObject);
		}

	}
}
