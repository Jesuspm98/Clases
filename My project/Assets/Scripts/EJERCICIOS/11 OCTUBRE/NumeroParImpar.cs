using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumeroParImpar : MonoBehaviour
{

    public int num;


    // Start is called before the first frame update
    void Start()
    {
        if ( num % 2 != 0 )
        {
            Debug.Log("el numero es impar");
        }
        else
        {
            Debug.Log("el numero es par");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
