using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickerManager : MonoBehaviour
{
    public GameObject startPanel, gamePanel, endPanel;

    public float playTime;

    private float timeLeft;

    private bool timeIsTicking = false;

    public Text timeLeftText;

    private int numberOfClicks = 0;

    public Text numberOfClicksText;

    private void Start()
    {
    }

    public void Click()
    {
        numberOfClicks++;
        numberOfClicksText.text = numberOfClicks.ToString();
    }

    public void Restart()
    {
        numberOfClicks = 0;
        numberOfClicksText.text = numberOfClicks.ToString();
    }

    public void StartCountdown()
    {
        timeLeft = playTime;
        timeIsTicking = true;
    }

    private void Update()
    {
        if (timeIsTicking)
        {
            timeLeft -= Time.deltaTime;
            timeLeftText.text = timeLeft.ToString();

            if (timeLeft < 0)
            {
                timeIsTicking = false;
                GameOver();
            }
        }
    }

    private void GameOver()
    {
        gamePanel.SetActive(false);
        endPanel.SetActive(true);
    }
}