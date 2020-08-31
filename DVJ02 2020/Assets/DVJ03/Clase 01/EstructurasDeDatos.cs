using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EstructurasDeDatos : MonoBehaviour
{
	public int pepe;
	public int[] pepeInt;
	public int[,] pepeIntMat;
	public int[][] pepeIntMat2;
	public List<int> pepeIntList;

	public Dictionary<string, int> dicc;

	public Dictionary<EstructurasDeDatos, int> diccEstructure;

	public Dictionary<Contruccion, int> importanciaDeContruccion;

	public Dictionary<string, Contruccion> construccionByName;
	public Dictionary<int, Contruccion> construccionByOrdenDePrioridad;

	public Dictionary<int, List<Contruccion>> construccionByTamanio;

	public List<Contruccion> construcciones;

	public class Contruccion
	{
		public string name;
		public int tamanio;
		public int superficie;
	}

	
	public class Enemy
	{
		public string construccionQueQuiereAtacar = "ayuntamiento";
	}

	void Start()
    {
	    dicc = new Dictionary<string, int>();

		dicc.Add("primer valor", 0);
		//dicc["primer valor"] => 0

	    foreach (KeyValuePair<string, int> keyValuePair in dicc)
	    {
		    //keyValuePair.Key
		    //keyValuePair.Value
		}

	    Contruccion ayuntamiento = new Contruccion { name = "ayuntamiento", tamanio = 10, superficie = 3 };
	    Contruccion ayuntamiento02 = new Contruccion { name = "ayuntamiento", tamanio = 20, superficie = 3 };
		Contruccion casa = new Contruccion { name = "casa", tamanio = 5 };
	    construcciones = new List<Contruccion>();
		construcciones.Add(ayuntamiento);
	    construcciones.Add(casa);


		diccEstructure = new Dictionary<EstructurasDeDatos, int>();

	    diccEstructure.Add(this, 0);


	    importanciaDeContruccion = new Dictionary<Contruccion, int>();
	    construccionByName = new Dictionary<string, Contruccion>();


		importanciaDeContruccion.Add(ayuntamiento, 0);
	    importanciaDeContruccion.Add(casa, 1);

	    construccionByName.Add("ayuntamiento", ayuntamiento);
	    construccionByName.Add("ayuntamiento", ayuntamiento02);
		construccionByName.Add("casa", casa);


	    for (int i = 0; i < construcciones.Count; i++)
	    {
		    if ("ayuntamiento" == construcciones[i].name)
		    {
				//hacer algo con construcciones[i]
			}
		}

		//hacer algo con construccionByName["ayuntamiento"]

		//Contruccion c = DB dame la casa con name = "ayuntamiento";


		//enemigo va a atacar y quiere saber que importacia tiene la contruccion
		//importanciaDeContruccion[casa] => 1

		//pepeInt[0]

		pepeInt[0] = 2;
	    pepeInt[0] = 5;

	}
}
