using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Time : MonoBehaviour
{
    public float timeRemaining = 10;
    public bool timerIsRunning = false;
    public Text timeText;

    public GameObject HUD;
    public GameObject GameOver;

    private void Start()
    {
        //timerIsRunning = true;
    }

    void Update()
    {
        if (timerIsRunning)
        {
            if (timeRemaining > 0)
            {
                timeRemaining -= UnityEngine.Time.deltaTime;
                DisplayTime(timeRemaining);
            }
            else
            {
                Debug.Log("Time has run out!");
                timeRemaining = 0;
                timerIsRunning = false;
                GameObject.Find("Main Camera").GetComponent<CameraMove>().enabled = false;
                GameObject.Find("Main Camera").GetComponent<ObjectClicker>().enabled = false;
                HUD.SetActive(true);
                GameOver.SetActive(true);
            }
        }
    }

    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);

        timeText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}