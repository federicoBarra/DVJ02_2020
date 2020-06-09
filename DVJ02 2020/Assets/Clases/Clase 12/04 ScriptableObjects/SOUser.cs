using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DVJ02.Clase12
{
	public class SOUser : MonoBehaviour //controlador del personaje.
	{
		//public List<ScriptableObjectExample> availableCharacters;

	    public ScriptableObjectExample initialData;

	    private void Start()
	    {
	        Debug.Log(initialData.nombre);
	        Debug.Log(initialData.fuerza);
	        if (initialData.portrait)
	            Debug.Log(initialData.portrait.name);
	    }
	}
}
