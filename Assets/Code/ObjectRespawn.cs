using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRespawn : MonoBehaviour
{
    public float time = 10;
    public float timeRemaining;
    public bool timerIsRunning = false;
    public GameObject Object;

    private void Start()
    {
        timerIsRunning = true;
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
                Object.SetActive(true);
                timeRemaining = 0;
                timerIsRunning = false;
                this.GetComponent<ObjectRespawn>().enabled = false;
            }
        }
    }

    public void StartTimer()
    {
        timerIsRunning = true;
        timeRemaining = time;
    }

    void DisplayTime(float timeToDisplay)
    {
        timeToDisplay += 1;

        float minutes = Mathf.FloorToInt(timeToDisplay / 60);
        float seconds = Mathf.FloorToInt(timeToDisplay % 60);
    }
}
