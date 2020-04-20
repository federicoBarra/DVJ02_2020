using UnityEngine;

namespace DVJ02.Clase06
{
    public class RayCastTester : MonoBehaviour
    {
        public GameObject cubo;
        public GameObject cilindro;
        public GameObject esfera;

        public float rotationSpeed = 10;

        public float rayDistance = 10;

        public LayerMask rayCastLayer;

        private void Update()
        {
            transform.Rotate(Vector3.up*rotationSpeed*Time.deltaTime);

            RaycastHit hit;
			//Debug.Log();
			//notese el out como prefijo del parametro hit.
			// el keyword out fuerza a la funcion Raycast a inicializar el objeto "hit"
			if (Physics.Raycast(transform.position, transform.forward, out hit, rayDistance, rayCastLayer))
            {
                Debug.DrawRay(transform.position, transform.forward*hit.distance, Color.yellow);
				string layerHitted = LayerMask.LayerToName(hit.transform.gameObject.layer);

                switch (layerHitted)
                {
                    case "Esferas01":
                        cubo.SetActive(true);
                        cilindro.SetActive(false);
                        esfera.SetActive(false);
                        break;
                    case "Esferas02":
                        cubo.SetActive(false);
                        cilindro.SetActive(true);
                        esfera.SetActive(false);
                        break;
                    case "Esferas03":
                        cubo.SetActive(false);
                        cilindro.SetActive(false);
                        esfera.SetActive(true);
                        break;
                }
            }
            else
            {
                Debug.DrawRay(transform.position, transform.forward*rayDistance, Color.white);
            }
	        //https://docs.unity3d.com/ScriptReference/Physics.Linecast.html
			//Debug.Log(hit.transform);
		}
    }
}
