using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DVJ02.Clase03
{
public class InputBasico : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
            Debug.Log("Alpha1 presionado");

        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        if (Input.GetKeyUp(KeyCode.Space))
        {
            Debug.Log("Barra espaciadora soltada");
        }

        if (Input.GetKey(KeyCode.A))
        {
            Debug.Log("Valor Horizontal al mantener A: " + horizontal);
            Debug.Log("Valor Vertical al mantener A: " + vertical);
        }
    }
}
}
