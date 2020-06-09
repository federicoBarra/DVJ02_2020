using System;

namespace DVJ02.Clase12
{
	[Serializable]
	public class PlayerStats // Model
	{
		public int life;

	    public int Strenght = 10;
	    public int Dexterity = 10;
	    public int Magic = 10;
	    public int Luck = 10;

		public static event Action<PlayerStats> OnPlayerDied; 

	    public void AddToAllStats()
	    {
	        Strenght++;
	        Dexterity++;
	        Magic++;
	        Luck++;
	    }

		public void DealDamage(int damage)
		{
			life -= damage;
			if (life < 0)
			{
				if (OnPlayerDied != null)
					OnPlayerDied(this);
			}
		}
	}
}