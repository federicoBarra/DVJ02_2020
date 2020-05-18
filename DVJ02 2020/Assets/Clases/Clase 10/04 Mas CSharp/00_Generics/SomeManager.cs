using System.Collections;
using System.Collections.Generic;
using DVJ02.Clase10;
using UnityEngine;

namespace DVJ02.Clase10
{
	public class SomeManager : MonoBehaviourSingleton<SomeManager>
	{
	    public override void Awake()
	    {
	        //base.Awake();
			Debug.Log("Se llamo al awake en mi clase");
	        // codigo del awake.
	    }

	    public void SomeMethod()
	    {
	        Debug.Log("SomeMethodCalled");

			//transform.position

	    }
	}
}

//
//public class GameManager : MonoBehaviourSingleton<GameManager>
//{
//	public void LoadLevel()
//	{
//
//	}
//}
//
//public class ScoreManager : MonoBehaviourSingleton<ScoreManager>
//{
//
//}
//
//public class UIManager : MonoBehaviour
//{
//	void Start()
//	{
//		GameManager.Get().LoadLevel();
//	}
//}
