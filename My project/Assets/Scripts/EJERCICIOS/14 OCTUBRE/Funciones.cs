using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Funciones : MonoBehaviour
{

    public float IVA ( float precio ) 
    {
        float res = precio * 0.21f;

        return res + precio;
    }

    public void FuncionVoid ( int Num ) 
    {
    
    }



    public int a;

    // Start is called before the first frame update
    void Start()
    {
        float x = IVA(a);

        Debug.Log("El importe con el IVA aplicado sería " + x + " €");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
