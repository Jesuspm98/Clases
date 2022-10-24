using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArraySuma : MonoBehaviour
{

    public float[] myArray;

    public float MediaArray() 
    {
        float sum = 0;

        for (int i = 0; i < myArray.Length; i++)
        {
            sum += myArray[i] / myArray[i];
        }
        
        float med = sum / myArray.Length;
        
        return med;
    }

    // Start is called before the first frame update
    void Start()
    {
        MediaArray();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
