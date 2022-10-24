using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplicarIntervalo : MonoBehaviour
{

    public int num;
    int res = 1;

    // Start is called before the first frame update
    void Start()
    {
            for (int i = num; i > 0; i--)
            {
                res *= i;
            }
            Debug.Log(res);
        }
    // Update is called once per frame
    void Update()
    {
        
    }
}