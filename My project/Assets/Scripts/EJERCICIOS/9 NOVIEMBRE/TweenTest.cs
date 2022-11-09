using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class TweenTest : MonoBehaviour
{
    public Transform objectToMove;

    private Transform targetDestination;

    public Transform initialPosition, finalPosition;

    public float timeToMove = 4;

    public Ease easeType;

    public float timeToWaitAtTheEnd = 2;

    public Color startColor;
    public Color endColor;
    private Color targetColor;

    public MeshRenderer rend;
    public float timeToChangeColor;
    public float timeToWaitBeforeChangingColors;

    private void Start()
    {
        //rend.material.color = startColor;

        //rend.material.DOColor(endColor, 4);

        //objectToMove.DOScale(new Vector3(2, 2, 2), 4);

        //objectToMove.DORotate(new Vector3(0, 90, 0), 6);

        targetDestination = finalPosition;
        StartCoroutine(MyFirstCorrutine());

        targetColor = endColor;
        StartCoroutine(ColorCorrutine());
    }

    private void Update()
    {
    }

    public IEnumerator MyFirstCorrutine()
    {
        while (true)
        {
            objectToMove.DOMove(targetDestination.position, timeToMove).SetEase(easeType);
            yield return new WaitForSeconds(timeToMove);
            SwapPositions();
            yield return new WaitForSeconds(timeToWaitAtTheEnd);
        }
    }

    public IEnumerator ColorCorrutine()
    {
        while (true)
        {
            rend.material.DOColor(targetColor, timeToChangeColor);
            yield return new WaitForSeconds(timeToChangeColor);
            SwapColor();
            yield return new WaitForSeconds(timeToWaitBeforeChangingColors);
        }
    }

    public IEnumerator RotateCoroutine()
    {
        objectToMove.DORotate(new Vector3(0, 90, 0), 6);
        yield return new WaitForSeconds(timeToMove);
    }

    public void SwapPositions()
    {
        if (targetDestination == finalPosition)
        {
            targetDestination = initialPosition;
        }
        else
        {
            targetDestination = finalPosition;
        }
    }

    public void SwapColor()
    {
        if (targetColor == endColor)
        {
            targetColor = startColor;
        }
        else
        {
            targetColor = endColor;
        }
    }
}