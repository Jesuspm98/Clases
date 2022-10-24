using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetodoArray : MonoBehaviour
{

    public int[] miArray;

    // Start is called before the first frame update
    void Start()
    {
        ShowArrayInv();
    }


    public void ShowArrayInv() 
    {
        for (int i = miArray.Length - 1; i >= 0; i--)
        {
            Debug.Log(miArray[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
