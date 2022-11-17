using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class CountDown : MonoBehaviour
{
    public float countDownTime;

    public System.Action endCountDown;

    //public System.Action<int> actionExample;

    //public System.Func<int> myFunctionExample;

    public UnityEvent miEventoDeUnity;

    private void Start()
    {
        StartCoroutine(CountDownCorrutine());
    }

    public IEnumerator CountDownCorrutine()
    {
        yield return new WaitForSeconds(countDownTime);
        if (endCountDown != null)
        {
            endCountDown();
        }
    }
}