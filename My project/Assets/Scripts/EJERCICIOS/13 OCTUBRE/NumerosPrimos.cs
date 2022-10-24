using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumerosPrimos : MonoBehaviour
{

    public int num;

    // Start is called before the first frame update
    void Start()
    {
    

        for (int i = num - 1; i > 1; i--)
        {
            if ( i % num == 0 )
            {
                Debug.Log("El numero es primo");
            }
            
        
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
