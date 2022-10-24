using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumeroNegativo : MonoBehaviour
{

    public int num;

    // Start is called before the first frame update
    void Start()
    {
        if ( num < 0 ) 
        {
            Debug.Log("El numero es negativo");
        }
        else 
        {
            Debug.Log("El numero es positivo");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
