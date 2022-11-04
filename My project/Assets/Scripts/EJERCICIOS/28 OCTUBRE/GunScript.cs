using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunScript : MonoBehaviour
{
    public Transform myCamera;

    public float range = 100f;

    public GameObject bulletImpactPrefab;

    public float impactForce = 10f;

    public int damageDealt = 1;

    private void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        RaycastHit hitInfo;

        if (Physics.Raycast(myCamera.position, myCamera.forward, out hitInfo, range))
        {
            //Destroy(hitInfo.collider.gameObject);

            GameObject bulletImpact = Instantiate(bulletImpactPrefab, hitInfo.point, Quaternion.LookRotation(hitInfo.normal));

            Destroy(bulletImpact, 2);

            Rigidbody rb = hitInfo.collider.gameObject.GetComponent<Rigidbody>();

            if (rb != null)
            {
                rb.AddForce(-hitInfo.normal * impactForce, ForceMode.Impulse);
            }

            Health health = hitInfo.collider.gameObject.GetComponent<Health>();
            if (health != null)
            {
                health.TakeDmg(damageDealt);
            }
        }
        else
        {
            Debug.Log("No ha impactado la bala");
        }
    }
}