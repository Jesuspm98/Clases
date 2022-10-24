using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Edad : MonoBehaviour



{

    public int numero1 = 18;
    public int numero2 = 17;
    public int resultado;




    // Start is called before the first frame update
    void Start()
    {
        if ( numero1 < 18 )
        {
            Debug.Log("Es menor de edad");
        }
        else
        {
            Debug.Log("Es mayor de edad");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
