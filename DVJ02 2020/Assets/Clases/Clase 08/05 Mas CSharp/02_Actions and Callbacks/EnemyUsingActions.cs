﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

namespace DVJ02.Clase08
{
	public class EnemyUsingActions : MonoBehaviour
	{
	    //definicion básica de un Action
	    //public delegate void Action<T>(T param);
		//public delegate void PunteroAFuncion(string s);
		//define el signature del delegate (delegate type)
		//Action<string>
		//!!! Un Action es un delegate ya predefinido usando Generics.

		//List<string>
		//Action<int>

		//public delegate void PunteroAFuncion(EnemyUsingActions s); //define el signature del delegate (delegate type)
		private Action<EnemyUsingActions> callbackOnDeath;
		//private PunteroAFuncion callbackOnDeathSimilar;

		//public delegate void PunteroAFuncion(); //define el signature del delegate (delegate type)
		Action pepe;

		//void Start()
		//{
		//	pepe();
		//	callbackOnDeath(this);
		//}

		private void OnMouseDown()
	    {
	        EnemyDied();
	    }

	    void EnemyDied()
	    {
	        DieAsACallback();
	    }

		public void AddCallback(Action<EnemyUsingActions> callback)
		{
			callbackOnDeath += callback;
		}

		public void SetCallback(Action<EnemyUsingActions> callback)
	    {
	        callbackOnDeath = callback;
	        //podría ser tambien
	        //callbackOnDeath += callback;
	    }

	    private void DieAsACallback()
	    {
	        if (callbackOnDeath != null)
	            callbackOnDeath(this);
	    }
	}
}
