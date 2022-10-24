using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeCelciusAKelvin : MonoBehaviour
{

    public float Celsius;
    public float Kelvin;


    // Start is called before the first frame update
    void Start()
    {
        Kelvin = Celsius + 273;
        Debug.Log("la temperatura en kelvin son: " + (Celsius + 273));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
