using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiposTriangulos : MonoBehaviour
{
    public float ladoIzqTri;
    public float ladoDerTri;
    public float BaseTri;

    // Start is called before the first frame update
    void Start()
    {
        if ( ladoIzqTri == ladoDerTri && ladoDerTri == BaseTri ) 
        {
            Debug.Log("El triangulo es Equilatero");
        }
        else if (ladoIzqTri == ladoDerTri || ladoDerTri == BaseTri) 
        {
            Debug.Log("El triangulo es Isosceles");
        }
        else 
        {
            Debug.Log("El triangulo es Escaleno");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
