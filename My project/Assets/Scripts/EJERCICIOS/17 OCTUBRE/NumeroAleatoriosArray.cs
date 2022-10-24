using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumeroAleatoriosArray : MonoBehaviour
{

    public float[] array;

    public void RandomArray() 
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Random.Range(10, 100);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        RandomArray();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
