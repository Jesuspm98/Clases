using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelegateTest : MonoBehaviour
{
    public delegate void DoSomething();

    public DoSomething something;

    public System.Action DoAction;

    public CountDown countDown;

    public GameObject objectToTurnOff;

    public MeshRenderer meshToChangeColor;
    public Color colorToChange;

    public Light lightToTurnOn;

    private void Start()
    {
        DoAction += TurnOnLight;
        DoAction();

        countDown.endCountDown += ObjectOff;
        countDown.endCountDown += ChangeColor;
        countDown.endCountDown += TurnOnLight;
    }

    public void ObjectOff()
    {
        objectToTurnOff.SetActive(false);
    }

    public void ChangeColor()
    {
        meshToChangeColor.material.color = colorToChange;
    }

    public void TurnOnLight()
    {
        lightToTurnOn.enabled = true;
    }
}