using System;
using UnityEngine;

namespace DVJ02.Clase08
{
public class CSAnonymMethods : MonoBehaviour
{
    public Action variasAcciones;
    public Action metodoAnonimo;

    private void Start()
    {
        metodoAnonimo = delegate { Debug.Log("Metodo Anónimo"); }; //anonymous method or inline code

			variasAcciones += metodoAnonimo;

        //XXX Estoy pisando la funcion anterior.
        metodoAnonimo = () => { Debug.Log("Metodo Anónimo 02"); };  //lambda expression

        variasAcciones += metodoAnonimo;

        if (variasAcciones != null)
            variasAcciones();


        Action<int> sendToLog = (param) => { Debug.Log("param: " + param); };
        //Es lo mismo que
        //UnityAction<int> sendToLog = delegate(int param) { Debug.Log("param: " + param); };

        sendToLog(5);
    }
}
}