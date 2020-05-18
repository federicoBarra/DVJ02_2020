using System.Collections.Generic;
using DVJ02.Clase10;
using UnityEngine;

public class Ejemplo
{
	void Init()
	{
		CSProperties cs = new CSProperties();

		Debug.Log(cs.Score);
		//cs.Score = 0;

		SomeOtherEnemy e = new SomeOtherEnemy();

		Debug.Log(e.Mat);


		List<int> listaDeInts = new List<int>()
		{
			1,2,34,5,5,35,345,
		};

		int count = listaDeInts.Count;
		//listaDeInts.Count = 10;
	}
}

namespace DVJ02.Clase10
{
	public class CSProperties : MonoBehaviour
	{
	    private int score;
	    public int Score
	    {
	        get { return score; }
	        private set { score = value; }
	    }

	    void Start()
	    {
	        SchrodingerEnemyManager sem = new SchrodingerEnemyManager();

	        int aliveEnemy = sem.AliveEnemyCount;

		    Score = 0;
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
		        for (var i = 0; i < enemies.Count; i++)
		        {
			        SchrodingerEnemy enemy = enemies[i];
			        if (enemy.IsAlive())
				        count++;
		        }

		        return count;
	        }

	    }
	}

	public class SomeOtherEnemy : MonoBehaviour
	{
		private float health;

		public float Health
		{
			get { return health; }
			set
			{
				health = value;
				if (health < 0)
					health = 0;
				if (health > 0)
					health = 1000;
			}
		}

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

		//public Material GetMaterial()
		//{
		//	if (!mat)
		//		mat = GetComponent<Renderer>().material;
		//	return mat;
		//}

		void Start()
		{
			mat = GetComponent<Renderer>().material;
		}


		void ReceiveDamage(float damage = 10)
		{
			Health -= 10;
		}

		//UnTexto.text = someOtherEnemy.health.ToString();

	}
}
