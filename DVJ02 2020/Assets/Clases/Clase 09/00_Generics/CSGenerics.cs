using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DVJ02.Clase08
{
	public class CSGenerics : MonoBehaviour
	{
	    private void Start()
	    {
	        GenericMethod<int>(0);
	        GenericMethod<string>("string");

	        SomeManager.Get().SomeMethod();
	    }

	    private void Update()
	    {

	    }

	    private void GenericMethod<T>(T index)
	    {
	        T something = index;
	        Debug.Log(something);
	    }
	}
}