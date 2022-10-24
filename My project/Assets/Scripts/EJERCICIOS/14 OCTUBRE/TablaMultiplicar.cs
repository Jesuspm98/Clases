using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TablaMultiplicar : MonoBehaviour
{

    public int tabla;
        
    public void TablaMult(int num)
    {
        for (int i = 0; i <= 10; i++)
        {
            Debug.Log(num + " por " + i + " es " + (num * i));
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        TablaMult(tabla);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
