using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DVJ02.Clase10
{
	public class DecouplingPlayer : MonoBehaviour
	{
		[SerializeField] private DecouplingBullet playerBulletPrefab;

		void Update()
		{
			if (Input.GetKeyDown(KeyCode.Space))
			{
				DecouplingBullet bullet = Instantiate(playerBulletPrefab, transform.position, Quaternion.identity);
				bullet.Shoot(transform.right);
			}
		}
	}
}