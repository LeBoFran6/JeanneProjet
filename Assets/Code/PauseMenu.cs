using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{

    public GameObject PauseCanvas;
    public GameObject OptionsCanvas;

    public Button Button;

    public Sprite NotPause;
    public Sprite IsPause;


    public void FairePause()
    {
        Button.image.sprite = IsPause;
        PauseCanvas.SetActive(true);
        GameObject.Find("Main Camera").GetComponent<Time>().timerIsRunning = false;
        GameObject.Find("Main Camera").GetComponent<CameraMove>().enabled = false;
        GameObject.Find("Main Camera").GetComponent<ObjectClicker>().enabled = false;
    }

    public void Reprendre()
    {
        Button.image.sprite = NotPause;
        PauseCanvas.SetActive(false);
        if(GameObject.Find("Tutorial").GetComponent<Tutorial>().tutoStep == 15)
        {
            GameObject.Find("Main Camera").GetComponent<Time>().timerIsRunning = true;
        }
        GameObject.Find("Main Camera").GetComponent<CameraMove>().enabled = true;
        GameObject.Find("Main Camera").GetComponent<ObjectClicker>().enabled = true;
    }

    public void Options()
    {
        PauseCanvas.SetActive(false);
        OptionsCanvas.SetActive(true);
    }

    public void Retour()
    {
        OptionsCanvas.SetActive(false);
        PauseCanvas.SetActive(true);
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void returnToMenu()
    {
        SceneManager.LoadScene("MenuScene");
    }
}
