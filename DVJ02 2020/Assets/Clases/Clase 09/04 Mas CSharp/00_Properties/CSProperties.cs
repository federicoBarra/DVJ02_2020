using System.Collections.Generic;
using UnityEngine;

namespace DVJ02.Clase08
{
	public class CSProperties : MonoBehaviour
	{
	    private int score;

	    public int Score
	    {
	        get { return score; }
	        set { score = value; }
	    }

	    void Start()
	    {
	        SchrodingerEnemyManager sem = new SchrodingerEnemyManager();

	        int aliveEnemy = sem.AliveEnemyCount;

	        //Esto va a tirar error.
	        //sem.AliveEnemyCount = 0;
	    }
	}

	public class SchrodingerEnemy
	{
		public bool IsAlive()
	    {
	        bool alive = false;
	        //...
	        return alive;
	    }
	}

	public class SchrodingerEnemyManager
	{
	    private int aliveEnemyCount;
	    private List<SchrodingerEnemy> enemies = new List<SchrodingerEnemy>(); 
	    public int AliveEnemyCount
	    {
	        get
	        {
	            int count = 0;
	            foreach (SchrodingerEnemy enemy in enemies)
	            {
	                if (enemy.IsAlive())
	                    count++;
	            }
	            return count;
	        }

	    }
	}

	public class SomeOtherEnemy : MonoBehaviour
	{
		private Material mat;
		public Material Mat
		{
			get
			{
				if (!mat)
					mat = GetComponent<Renderer>().material;
				return mat;
			}
		}
	}
}
