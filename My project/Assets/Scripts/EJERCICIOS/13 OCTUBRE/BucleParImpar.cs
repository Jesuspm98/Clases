using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BucleParImpar : MonoBehaviour
{

    public int num;

    // Start is called before the first frame update
    void Start()
    {

        for ( num = 0; num <= 100; num++)
        {
            if ( num % 2 == 0 )
            {
                Debug.Log(num);
            }
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
