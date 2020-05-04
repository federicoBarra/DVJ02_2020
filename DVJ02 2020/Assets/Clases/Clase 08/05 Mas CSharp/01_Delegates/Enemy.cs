using System;
using UnityEngine;

namespace DVJ02.Clase08
{
public class Enemy : MonoBehaviour //celebrity
{
    //Un delegate es basicamente un puntero a funcion.
    public delegate void EnemyKilledAction(Enemy enemy); //define el signature del delegate (delegate type)
    public EnemyKilledAction OnEnemyKilled; //(delegate instance)
	//public Action<Enemy> OnEnemyKilled; //(delegate instance)

	private void OnMouseDown()
    {
        EnemyDied();
    }

    void EnemyDied()
    {
	    if (OnEnemyKilled != null) // conocido como dispatch delegate.
		    OnEnemyKilled(this);
	    //DieAsADispatcherAsStatic();
    }
















	public static EnemyKilledAction OnEnemyKilledAsStatic; //(delegate instance)

    private void DieAsADispatcherAsStatic()
    {
        if (OnEnemyKilledAsStatic != null)
            OnEnemyKilledAsStatic(this);
    }

}
}
