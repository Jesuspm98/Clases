using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoWhileImpares : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int i = 500;

        do
        {
            i--;
            if (i % 2 != 0)
            {
                Debug.Log(i);
            }
        } while ( i > 0 );
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
