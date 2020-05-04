using System.Collections.Generic;
using UnityEngine;

namespace DVJ02.Clase08
{
public class EnemyManager : MonoBehaviour //fan
{
    public GameObject enemyPrefab;
    private List<Enemy> enemies = new List<Enemy>();
    // Use this for initialization
    private void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            GameObject go = Instantiate(enemyPrefab, new Vector3(i*2 - 10, 1, 0), Quaternion.identity);
            Enemy e = go.GetComponent<Enemy>();

            // as a dispatcher.
            e.OnEnemyKilled += EnemyDiedMethod01;
            e.OnEnemyKilled += EnemyDiedMethod02;
            enemies.Add(e);
        }

        //UseDelegateAsStatic();
    }

    private void EnemyDiedMethod01(Enemy e)
    {
        Debug.Log("Using Dispatcher. Enemy has died " + e.name);

		//for de todos los enemigos
		//	aumentar agresividad
    }

    private void EnemyDiedMethod02(Enemy e)
    {
        Debug.Log("Using Dispatcher 02. Enemy has died " + e.name);
    }








    void UseDelegateAsStatic()
    {
        Enemy.OnEnemyKilledAsStatic += EnemyDiedMethod01;
        Enemy.OnEnemyKilledAsStatic += EnemyDiedMethod02;
    }


    void OnDestroy()
    {
        for (int i = 0; i < 10; i++)
        {
            Enemy e = enemies[i];
    
            e.OnEnemyKilled -= EnemyDiedMethod01;
            e.OnEnemyKilled -= EnemyDiedMethod02;
        }
    }
}
}