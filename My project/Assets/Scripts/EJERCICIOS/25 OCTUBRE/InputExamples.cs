using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputExamples : MonoBehaviour
{
    private void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    Debug.Log("El player ha pulsado el Espacio");
        //}

        if (Input.GetButtonDown("Jump"))
        {
            Debug.Log("El player ha saltado");
        }

        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("El player est� disparando");
        }

        //if (Input.GetKey(KeyCode.Space))
        //{
        //    Debug.Log("El player est� pulsando el Espacio");
        //}

        //if (Input.GetKeyUp(KeyCode.Space))
        //{
        //    Debug.Log("El player ha soltado el espacio");
        //}

        //if (Input.GetMouseButtonDown(0))
        //{
        //    Debug.Log("He pulsado el boton izquierdo del mouse");
        //}
    }
}