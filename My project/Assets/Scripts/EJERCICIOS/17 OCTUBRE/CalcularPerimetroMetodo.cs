using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalcularPerimetroMetodo : MonoBehaviour
{

    public int largo, ancho;

    public float CalcularPerimetro(int num1, int num2) 
    {
        return (num1 * num1) + (num2 * num2);
    }

    // Start is called before the first frame update
    void Start()
    {
        Circulo circulo = new Circulo();
        circulo.radio = 2;
        float perCir = circulo.Perimetro();
        float arCir = circulo.Area();
        float volCir = circulo.Volumen();

        Rectangulo rec = new Rectangulo();
        rec.ladoA = 4;
        rec.ladoB = 7;


        float x = CalcularPerimetro ( largo, ancho );

        Debug.Log("El perimetro del rectangulo es " + x + " metros.");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
