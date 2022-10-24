using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{

    //+ * / %   -
    // == != > >= < <=
    //int float string bool
    // && ||
    //public int Y PUEDO CREAR UN COMANDO con "()"( Suma, Resta, etc...)


    // Start is called before the first frame update
    void Start()
    {
        int a = 2;
        int b = 7;
        int x = Suma( a, b);

    }
    // Update is called once per frame
    void Update()
    {
        
    }


    public int Suma( int num1, int num2 )
    {
        int res = num1 + num2;

        return res;
    }


}