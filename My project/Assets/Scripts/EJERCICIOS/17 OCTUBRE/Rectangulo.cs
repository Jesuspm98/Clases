using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rectangulo 
{
    public float ladoA, ladoB;

    public float Perimetro()
    {
        return ladoA * 2 + ladoB * 2;
    }

    public float Area() 
    {
        return ladoA * ladoB;
    }


}
