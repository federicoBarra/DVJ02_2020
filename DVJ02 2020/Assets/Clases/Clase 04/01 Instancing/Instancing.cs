using System.Collections.Generic;
using DVJ02.Clase03.EnClase;
using UnityEngine;

namespace DVJ02.Clase04
{
    public class Instancing : MonoBehaviour
    {
	    public Camera2 cam;

	    public Transform objetoAMover;

        public Transform prefab;

	    public Planeta planetPrefab; //Transform

	    public List<Material> planetMaterials;
	    public Material[] planetMaterialsAsArray;

	    public Dictionary<string, int> radioPorPlaneta;

	    public List<Planeta> generatedPlanets = new List<Planeta>();

	    private float time = 0;

		private void Start()
        {
			radioPorPlaneta.Add("Tierra", 987123876);
	        radioPorPlaneta.Add("Marte", 987123876);

			Debug.Log(radioPorPlaneta["Marte"]);
			//planetMaterialsAsArray.Length
			//Random.Range(0,2f)
			for (int i = 0; i < 10; i++)
            {
                GameObject go = Instantiate(planetPrefab, new Vector3(i*2.0F, 0, 0), Quaternion.identity).gameObject;

				//go.AddComponent<Planeta>();

	            Planeta p = go.GetComponent<Planeta>();

	            int validIndex = i % planetMaterials.Count;
	            go.GetComponent<MeshRenderer>().material = planetMaterials[validIndex];

				p.Initialize(gameObject.transform, i * 3, 654);
	            //p.radius = i * 3;
	            //p.sun = gameObject.transform;

	            generatedPlanets.Add(p);
	            cam.planetas.Add(go);
			}
		}

	    public Vector3 desde;
	    public Vector3 hasta;

		void Update()
	    {
		    Mathf.Lerp(0, 10, 0); // = 0
		    Mathf.Lerp(0, 10, 0.5f); // = 5
		    Mathf.Lerp(0, 10, 1); // = 10

		    Debug.Log("Valor de lerp: " + Mathf.Lerp(0, 10, time)); // = 10

		    time += Time.deltaTime;

		    objetoAMover.transform.position = Vector3.Lerp(desde, hasta, time);
	    }

    }
}
