using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DVJ02.Clase12
{
	public class PlayerController : MonoBehaviour //Controller
	{
	    public PlayerStats stats;

		void Start()
		{
			PlayerStats.OnPlayerDied += PlayerDied;
		}

	    // Update is called once per frame
	    private void Update()
	    {
	        if (Input.GetKeyDown(KeyCode.Space))
	            LevelUp();

			//setposition
	    }

	    private void LevelUp()
	    {
	        stats.AddToAllStats();
	    }

		void PlayerDied(PlayerStats ps)
		{
			//hacer algo.
		}

		//OnColitioEnter(...)
		//{
		//	
		//}
	}
}