using System.Collections;
using UnityEngine;

namespace DVJ02.Clase06
{
//https://docs.unity3d.com/Manual/Coroutines.html
public class CoroutineExample : MonoBehaviour
{
    public Transform target;
    void Start()
    {
        StartCoroutine("WaitAndPrint");
        // o
        StartCoroutine(WaitAndPrint(10));

        //StopCoroutine(WaitAndPrint());
        StartCoroutine(Fade());
    }

    IEnumerator WaitAndPrint()
    {
        yield return new WaitForSeconds(5);
        print("WaitAndPrint " + Time.time);
    }

    IEnumerator WaitAndPrint(int waitTime)
    {
        yield return new WaitForSeconds(waitTime);
        print("WaitAndPrint " + Time.time);
    }


    IEnumerator Fade()
    {
        yield return new WaitForSeconds(1);
        float t = 1;
        Material mat = target.GetComponent<MeshRenderer>().material;
        Color c = mat.color;

        while (t > 0)
        {
            t -= Time.deltaTime;
            Debug.Log("t: " + t);
            c.a = t;
            mat.color = c;// que pasa si yo comento esta linea???
            yield return null;
        }
    }
}
}