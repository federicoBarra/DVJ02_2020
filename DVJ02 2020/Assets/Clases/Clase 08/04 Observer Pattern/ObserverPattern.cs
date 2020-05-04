using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DVJ02.Clase08
{
	public class ObserverPattern : MonoBehaviour
	{
		public class Observer //(ej: Manager, Sonido, UI, etc) //fan
		{
			public virtual void Notify(Subject s, string notification)
			{
				//Pasó tal cosa en el Subject
			}
		}


		public class Subject //celebrity
		{
			private List<Observer> observers;

			public void AddObserver(Observer o)
			{
				observers.Add(o);
			}

			public void Notify(string notification)
			{
				foreach (Observer o in observers)
				{
					o.Notify(this, notification);
				}
			}
		}






		public class SubjectEnemy : Subject //celebrity
		{
			void Update()
			{
				//...
				Notify("Enemy Exploded");
				//...
			}
		}

		public class SubjectEnemyManager : Observer //fan 01
		{
			private List<SubjectEnemy> enemies;

			void Start()
			{
				foreach (SubjectEnemy se in enemies)
				{
					se.AddObserver(this);
				}
			}

			public override void Notify(Subject s, string notification)
			{
				base.Notify(s, notification);
				//Pasó tal cosa en el Subject
			}
		}

		public class ScoreManager : Observer //fan 02
		{
			private List<SubjectEnemy> enemies;

			void Start()
			{
				foreach (SubjectEnemy se in enemies)
				{
					se.AddObserver(this);
				}
			}

			public override void Notify(Subject s, string notification)
			{
				base.Notify(s, notification);
				//Pasó tal cosa en el Subject
			}
		}
	}
}