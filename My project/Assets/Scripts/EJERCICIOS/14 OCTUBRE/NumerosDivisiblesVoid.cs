using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NumerosDivisiblesVoid : MonoBehaviour
{

    public int numeroDivisor;

    public void NumerosDivisibles(int num)
    {
        for (int i = num; i > 0; i--)
        {
            if ( num % i == 0 )
            {
                Debug.Log("Los divisores de " + num + " son " + i);
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        NumerosDivisibles(numeroDivisor);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
