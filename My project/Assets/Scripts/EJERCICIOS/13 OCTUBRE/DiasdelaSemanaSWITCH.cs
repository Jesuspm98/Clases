using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiasdelaSemanaSWITCH : MonoBehaviour
{

    int dia = 1;

    // Start is called before the first frame update
    void Start()
    {
        switch (dia)
        {
            case 1:
                Debug.Log("Es Lunes");
                break;

            case 2:
                Debug.Log("Es Martes");
                break;

            case 3:
                Debug.Log("Es Miercoles");
                break;

            case 4:
                Debug.Log("Es Jueves");
                break;

            case 5:
                Debug.Log("Es Viernes");
                break;

            case 6:
                Debug.Log("Es Sabado");
                break;

            case 7:
                Debug.Log("Es Domingo");
                break;

            default:
                Debug.Log("No existe ese dia de la semana");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
