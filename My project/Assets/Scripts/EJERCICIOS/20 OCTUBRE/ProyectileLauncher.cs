using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProyectileLauncher : MonoBehaviour
{
    public Transform shootPoint;
    public GameObject proyectilePrefab;

    public float timeToShoot = 1;
    private float timeSinceLastShoot = 0;

    private void Start()
    {
    }

    private void Update()
    {
        timeSinceLastShoot += Time.deltaTime;

        if (timeSinceLastShoot >= timeToShoot)
        {
            Instantiate(proyectilePrefab, shootPoint.position, shootPoint.rotation);
            timeSinceLastShoot = 0;
        }
    }
}