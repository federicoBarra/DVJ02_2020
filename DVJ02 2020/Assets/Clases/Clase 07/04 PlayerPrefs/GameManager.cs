using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace DVJ02.Clase07
{
	public class GameManager : MonoBehaviour
	{
		private int a;
		public bool pepe;
		private int b;
		public bool tito;


		//public List<Pino> pinos;
		public int Score = 10;
		public string gameManagerName;

	    private static GameManager instance;
	    public static GameManager Get()
	    {
	        return instance;
	    }

	    private void Awake()
	    {
		    Debug.Log("GameManager Awake: " + gameManagerName +  " - ID:" + GetInstanceID() + " - At time: " + DateTime.Now);
			if (instance != null)
	        {
	            Debug.Log("GameManager already created, thera can be only one. Destroing this reference.");
	            Destroy(gameObject);
		        instance.SeachReferences();
				return;
	        }

			DontDestroyOnLoad(gameObject);
	        instance = this;
		    instance.SeachReferences();
		}

		void Start()
		{
			Debug.Log("GameManager Start.");
		}

		void SeachReferences()
		{
			//pinos = FindObjectsOfType<Pino>().ToList();
		}

	    public void StartGame()
	    {
	        Score = 0;
	        SceneManager.LoadScene("DontDestroy 02 Game");
	    }

	    public void EndGame()
	    {
	        SceneManager.LoadScene("DontDestroy 03 End");
	    }


	    public void Load()
	    {
	        Persistance.Get().LoadGame(this);
	    }

	    public void Save()
	    {
	        Persistance.Get().SaveGame(this);
	    }

	}

}