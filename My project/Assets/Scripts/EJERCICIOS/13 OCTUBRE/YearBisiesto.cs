using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class YearBisiesto : MonoBehaviour
{

    public int year;

    // Start is called before the first frame update
    void Start()
    {


        if ( ( year % 4 == 0 && year % 100 != 0 ) || year % 400 == 0 )
        {
            Debug.Log("El año es Bisiesto");
        }
        else 
        {
            Debug.Log("El año no es Bisiesto");
        }
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
