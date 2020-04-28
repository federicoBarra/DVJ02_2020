using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DVJ02.Clase07
{
//Teorica implementacion de un GameObject en Unity
    public class GameObjectCroquis
    {
        public Transform transform;
        private List<Component> componentes;

        //... demas variables del GameObject ...

        //constructor
        public GameObjectCroquis(string data)
        {

        }

        public void ConstructorDelGameObject(string data)
        {
            //transform = new Transform(data.dataDelComponenteTransform);
            //for de los componentes en "data"
            //  componente = new Component(data.dataDeEsteComponente)
            //  componentes.add(componente)
			//Awake();
        }

        public Component GetComponent()
        {
            Component c = null;
            //busca el componente que le pedimos
            //si lo encuentra lo devuelve.
            return c;
        }


        //... demas metodos de la implementación de GameObject...
    }

}