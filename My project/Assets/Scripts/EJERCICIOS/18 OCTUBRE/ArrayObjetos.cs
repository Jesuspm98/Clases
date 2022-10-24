using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayObjetos : MonoBehaviour
{

    public GameObject[] misObjetos;


    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < misObjetos.Length; i++)
        {
            misObjetos[i].SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
