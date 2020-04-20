using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DVJ02.Clase03
{
    public class DictionaryExample : MonoBehaviour
    {
        public Dictionary<string, int> intsByStringsDictionary;

        public Dictionary<string, List<int>> intListsByStringsDictionary;

        // Start is called before the first frame update
        private void Start()
        {
            intsByStringsDictionary = new Dictionary<string, int>();

            intsByStringsDictionary.Add("tito", 5);
            intsByStringsDictionary.Add("pepe", 6);


            intListsByStringsDictionary = new Dictionary<string, List<int>>();

            intListsByStringsDictionary.Add("Tito", new List<int>() {4, 5, 6});
            List<int> tempList = new List<int>();

            tempList.Add(10);
            tempList.Add(30);

            intListsByStringsDictionary.Add("Pepe", tempList);

	        foreach (KeyValuePair<string, int> keyValuePair in intsByStringsDictionary)
	        {
		        
	        }

            //etc
        }
    }
}