using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fan : PlayerTrigger
{
    public float forceMagnitud;

    public override void OnplayerStay(GameObject playerObject)
    {
        Rigidbody rb = playerObject.GetComponent<Rigidbody>();

        rb.AddForce(Vector3.up * forceMagnitud, ForceMode.Force);
    }
}