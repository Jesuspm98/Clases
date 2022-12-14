using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Granade : MonoBehaviour
{
    public float timeToExplote;

    private bool hasExploded;

    public GameObject explosionParticlesPrefab;

    public float explosionRadius = 2;

    public float explosionForce = 200;

    private void Update()
    {
        timeToExplote -= Time.deltaTime;

        if (timeToExplote < 0 && !hasExploded)
        {
            Explode();

            hasExploded = true;
        }
    }

    private void Explode()
    {
        GameObject explosionEffect = Instantiate(explosionParticlesPrefab, transform.position, transform.rotation);

        Collider[] colliders = Physics.OverlapSphere(transform.position, explosionRadius);

        for (int i = 0; i < colliders.Length; i++)
        {
            Rigidbody rb = colliders[i].GetComponent<Rigidbody>();

            if (rb != null)
            {
                rb.AddExplosionForce(explosionForce, transform.position, explosionRadius);
            }
        }

        Destroy(explosionEffect, 2f);
        Destroy(gameObject);
    }
}