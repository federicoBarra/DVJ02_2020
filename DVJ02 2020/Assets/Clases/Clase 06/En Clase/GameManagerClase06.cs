using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class GameManagerClase06 : MonoBehaviour
{
	public List<GameObject> pinosGos;
	public GameObject[] pinosGosArray;
	public List<Pino> pinos;
	public Pino[] pinosArray;

	public List<GameObject> pinosGos02;

	void Start()
    {
		//Encontrar objetos mediante tags
	    pinosGosArray = GameObject.FindGameObjectsWithTag("TagPino");

	    foreach (GameObject o in pinosGosArray)
	    {
		    Debug.Log(o.name);
	    }

	    for (int i = 0; i < pinosGosArray.Length; i++)
	    {
		    GameObject o = pinosGosArray[i];
		    Debug.Log(o.name);
		}
		//pinos[0].gameObject

	    pinosArray = FindObjectsOfType<Pino>();
	    pinos.Clear();

	    foreach (Pino pino in pinosArray)
	    {
		    pinos.Add(pino);
	    }

	    pinos = pinosArray.ToList();

	    //Pino p = pinosArray.Select();

	    int algunValor = pinos[0] + pinos[1];

		GameObject.Find("Pino"); //ESTO NO!
    }

    void Update()
    {
		//pinos = FindObjectsOfType<Pino>().ToList();
	}
}
