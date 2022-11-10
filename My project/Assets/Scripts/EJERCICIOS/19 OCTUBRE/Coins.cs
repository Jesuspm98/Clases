using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : PlayerTrigger
{
    public int amountToGive = 1;

    private AudioSource myAudioSource;

    private MeshRenderer coinMesh;

    private Collider coinCollider;

    private void Start()
    {
        myAudioSource = GetComponentInChildren<AudioSource>();

        coinMesh = GetComponentInChildren<MeshRenderer>();

        coinCollider = GetComponentInChildren<Collider>();
    }

    public override void OnPlayerEnter(GameObject playerObject)
    {
        CoinCounter coinCounter = playerObject.GetComponent<CoinCounter>();
        coinCounter.GetCoins(amountToGive);

        myAudioSource.Play();

        coinMesh.enabled = false;

        coinCollider.enabled = false;

        StartCoroutine(DestroyCoinCorrutine());
    }

    public IEnumerator DestroyCoinCorrutine()
    {
        yield return new WaitForSeconds(myAudioSource.clip.length);
        Destroy(gameObject);
    }
}