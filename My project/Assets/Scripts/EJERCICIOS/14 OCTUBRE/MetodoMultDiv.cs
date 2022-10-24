using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MetodoMultDiv : MonoBehaviour
{

    public int Mult (int num1, int num2)
    {
        int res = num1 * num2;

        return res;
    }

    public int Div (int num1, int num2) 
    {
        int res = num1 / num2;

        return res;
    }

    // Start is called before the first frame update
    void Start()
    {

        int a = 5;
        int b = 4;
        int x = Mult ( a, b );

        Debug.Log(x);

        int c = 8;
        int d = 2;
        int z = Div ( c, d );

        Debug.Log(z);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
