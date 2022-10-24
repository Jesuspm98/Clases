using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CalcularArea : MonoBehaviour
{

    public float numAncho;
    public float numAltura;
    public float numArea;

    // Start is called before the first frame update
    void Start()
    {
        numArea = numAncho * numAltura;
        Debug.Log("el area del rectangulo es " + numArea + " metros" );
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
