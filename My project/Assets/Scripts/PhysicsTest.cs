using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsTest : MonoBehaviour
{
    public Rigidbody myRigidbody;

    public Vector3 rigidbodyVelocity;

    public float forceMagnitude;

    public Vector3 forceDirection;

    // Start is called before the first frame update
    private void Start()
    {
        myRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    private void Update()
    {
        rigidbodyVelocity = myRigidbody.velocity;
    }

    private void FixedUpdate()
    {
        myRigidbody.AddForce(forceDirection * forceMagnitude, ForceMode.Force);
    }
}