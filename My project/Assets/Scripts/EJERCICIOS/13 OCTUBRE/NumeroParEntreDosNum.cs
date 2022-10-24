using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumeroParEntreDosNum : MonoBehaviour
{

    public int num1;
    public int num2;

    // Start is called before the first frame update
    void Start()
    {
        int i = num1;

        if ( num1 < num2 )
        {
            for ( i = num1; i <= num2; i++)
            {
                if ( i % 2 == 0 )
                {
                    Debug.Log(i);
                }
            }
   
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
