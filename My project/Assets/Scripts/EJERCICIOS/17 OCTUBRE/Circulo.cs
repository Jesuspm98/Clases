using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circulo 
{
    public float diametro = 6;
    public float radio = 3;
    public float volumen;

    public float Perimetro () 
    {
        return 3.14f * diametro;
    }

    public float Area () 
    {
        return radio * radio * 3.14f;
    }

    public float Volumen() 
    {
        return 4 / 3 * radio * radio * radio * 3.14f;
    }



}