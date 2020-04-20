using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace DVJ02.Clase03
{
    public class ListsExample : MonoBehaviour
    {
        public List<int> listaDeInts;

        private void Start()
        {
            listaDeInts = new List<int>();

            listaDeInts.Add(0);
            listaDeInts.Add(1);

            listaDeInts.Remove(0);

            Debug.Log(listaDeInts[0]);

            Debug.Log(listaDeInts.Count);

            //etc

            int[] arrayDeInts = {0, 2, 0, 2, 0, 5, 0, 6, 4, 87, 56,};

            List<int> pepeList;

            pepeList = arrayDeInts.ToList(); //using System.Linq;
        }
    }
}

