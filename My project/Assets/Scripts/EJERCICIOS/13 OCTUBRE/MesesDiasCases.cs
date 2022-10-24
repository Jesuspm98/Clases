using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MesesDiasCases : MonoBehaviour
{

    public int mes;
    public string myString;

    // Start is called before the first frame update
    void Start()
    {

        switch (mes)
        {
            case 1:
            case 3:
            case 5:
            case 7:
            case 8:
            case 10:
            case 12:
                Debug.Log("Tiene 31 dias");
                break;

            case 4:
            case 6:
            case 9:
            case 11:
                Debug.Log("Tiene 30 dias");
                break;

            case 2:
                Debug.Log("Tiene 28 dias pero si es Bisiesto tiene 29.");
                break;

            default:
                Debug.Log("No existe ese mes del año.");
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
