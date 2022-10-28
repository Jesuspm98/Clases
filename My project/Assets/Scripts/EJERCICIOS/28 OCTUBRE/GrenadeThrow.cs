using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrenadeThrow : MonoBehaviour
{
    public GameObject grenadePrefab;

    public Transform myCamera;

    public float throwForce;

    private void Update()
    {
        if (Input.GetButtonDown("Fire2"))
        {
            ThrowGrenade();
        }
    }

    private void ThrowGrenade()
    {
        GameObject grenade = Instantiate(grenadePrefab, myCamera.position, Quaternion.identity);

        Rigidbody rb = grenade.GetComponent<Rigidbody>();

        rb.AddForce(myCamera.forward * throwForce, ForceMode.Impulse);
    }
}