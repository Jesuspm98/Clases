using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class aFarenheit : MonoBehaviour
{

    public float celsius;
    public float farenheit;

    // Start is called before the first frame update
    void Start()
    {
        farenheit = celsius * 9 / 5 + 32;
        Debug.Log("La temperatura Farenheit es " + farenheit + "grados");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
