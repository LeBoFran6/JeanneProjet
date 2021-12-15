using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public GameObject Canvas;
    public GameObject CanvasMenu;
    public GameObject CanvasOptions;
    public GameObject CanvasTuto;
    public GameObject Cinematique;
    public GameObject Credits;

    public bool tutorial = false;

    public void CloseCanvas()
    {
        Canvas.SetActive(false);
        GameObject.Find("Main Camera").GetComponent<CameraMove>().enabled = true;
        GameObject.Find("Main Camera").GetComponent<ObjectClicker>().enabled = true;
        GameObject.Find("Tutorial").GetComponent<Tutorial>().enabled = true;
    }

    public void ReturnToMenu()
    {
        SceneManager.LoadScene("MenuScene");
    }

    public void PasserCinematique()
    {
        if(tutorial == false)
        {
            SceneManager.LoadScene("GameScene");
        }
        if (tutorial == true)
        {
            SceneManager.LoadScene("GameTutoScene");
        }
    }

    public void Play()
    {
        CanvasMenu.SetActive(false);
        CanvasTuto.SetActive(true);
    }

    public void PlayTuto()
    {
        tutorial = true;
        CanvasTuto.SetActive(false);
        Cinematique.SetActive(true);
    }

    public void PlayGame()
    {
        tutorial = false;
        CanvasTuto.SetActive(false);
        Cinematique.SetActive(true);
    }

    public void Options()
    {
        CanvasMenu.SetActive(false);
        CanvasOptions.SetActive(true);
    }

    public void ReturnOptions()
    {
        CanvasOptions.SetActive(false);
        CanvasMenu.SetActive(true);
    }

    public void LesCredits()
    {
        CanvasMenu.SetActive(false);
        Credits.SetActive(true);
    }

    public void ReturnCredits()
    {
        Credits.SetActive(false);
        CanvasMenu.SetActive(true);
    }
}
