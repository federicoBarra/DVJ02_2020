using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DVJ02.Clase08
{
	public class SomeManager : MonoBehaviourSingleton<SomeManager>
	{
	    public override void Awake()
	    {
	        base.Awake();
	        // codigo del awake.
	    }

	    public void SomeMethod()
	    {
	        Debug.Log("SomeMethodCalled");
	    }
	}
}
