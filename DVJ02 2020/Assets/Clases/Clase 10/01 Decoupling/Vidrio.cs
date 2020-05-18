using System.Collections;
using System.Collections.Generic;
using DVJ02.Clase10;
using UnityEngine;

public class Vidrio : MonoBehaviour, IDamageable
{
	public void GetDamage(float damage)
	{
		Destroy(gameObject);
	}
}
