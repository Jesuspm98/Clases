using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaCirculo : MonoBehaviour
{

    public float Radio;
    public float Area;

    // Start is called before the first frame update
    void Start()
    {
        Area = Radio * Radio * 3.14f;
        Debug.Log("El area del circulo es " + Area + " metros");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
