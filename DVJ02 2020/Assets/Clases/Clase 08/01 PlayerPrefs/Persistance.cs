using System.Collections;
using System.Collections.Generic;
using DVJ02.Clase07;
using UnityEngine;

namespace DVJ02.Clase08
{
public class Persistance : MonoBehaviour
{
    private static Persistance instance;

    public static Persistance Get()
    {
        return instance;
    }

    private void Awake()
    {
        if (instance != null)
        {
            Debug.Log("PersistanceManager already created, thera can be only one. Destroing this reference.");
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);
        instance = this;
    }

    public void SaveGame(GameManager g)
    {
        PlayerPrefs.SetInt("Score", g.Score);
    }

    public void LoadGame(GameManager g)
    {
        if (PlayerPrefs.HasKey("Score"))
        {
            g.Score = PlayerPrefs.GetInt("Score");
        }
        else
        {
            Debug.Log("Nothing to Load!");
        }
    }

    public void ClearSaves()
    {
        PlayerPrefs.DeleteAll();
    }

}
}