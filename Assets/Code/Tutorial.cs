using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tutorial : MonoBehaviour
{
    public GameObject ScriptCamera;
    public GameObject ScriptAtelier;

    public GameObject TutorialCanvas;
    public GameObject imageObjectif;
    public GameObject texteObjectif;
    public Text TexteObjectif;


    public GameObject tuto1;
    public GameObject tuto2;
    public GameObject tuto3;
    public GameObject tuto4;
    public GameObject tuto5;
    public GameObject tuto6;
    public GameObject tuto7;
    public GameObject tuto8;
    public GameObject tuto9;



    public GameObject Fleche;
    public GameObject FlecheCanvas;
    public GameObject FlecheCanvas2;


    public GameObject Jeanne;
    public Sprite jeanne1;
    public Sprite jeanne2;
    public Sprite jeanne3;


    public GameObject HUD;
    public Sprite HUDTimer;
    public GameObject TimerGame;



    public float Fer;
    public float PlaquesFer;
    public float FlanCuivre;
    public float PiecesCuivre;
    public bool decoupeuse = false;
    public bool mouleuseCruivre = false;

    public float tutoStep = 0;

    public float Timer = 0;
    public bool timergo = false;
        

    public void Start()
    {
        GameObject.Find("Main Camera").GetComponent<CameraMove>().enabled = false;
        GameObject.Find("Main Camera").GetComponent<ObjectClicker>().enabled = false;
    }

    void Update()
    {
        Fer = ScriptCamera.GetComponent<ObjectClicker>().FerC;
        PlaquesFer = ScriptCamera.GetComponent<ObjectClicker>().PlaquesFer;
        FlanCuivre = ScriptCamera.GetComponent<ObjectClicker>().FlanCuivre;
        PiecesCuivre = ScriptCamera.GetComponent<ObjectClicker>().PiecesCuivre;
        decoupeuse = ScriptAtelier.GetComponent<Atelier>().decoupeuse;
        mouleuseCruivre = ScriptAtelier.GetComponent<Atelier>().mouleuseCruivre;


        if (Input.GetMouseButtonDown(0) && tutoStep == 0)
        {
            tuto1.SetActive(false);
            TutorialCanvas.SetActive(false);
            imageObjectif.SetActive(true);
            texteObjectif.SetActive(true);
            GameObject.Find("Main Camera").GetComponent<CameraMove>().enabled = true;
            GameObject.Find("Main Camera").GetComponent<ObjectClicker>().enabled = true;
            tutoStep = 1;
        }
        if(Fer >= 1000 && tutoStep == 1)
        {
            GameObject.Find("Main Camera").GetComponent<CameraMove>().enabled = false;
            GameObject.Find("Main Camera").GetComponent<ObjectClicker>().enabled = false;
            Jeanne.GetComponent<Image>().sprite = jeanne2;
            TutorialCanvas.SetActive(true);
            imageObjectif.SetActive(false);
            texteObjectif.SetActive(false);
            tuto2.SetActive(true);
            tutoStep = 2;
        }
        if (Input.GetMouseButtonDown(0) && tutoStep == 2)
        {
            tuto2.SetActive(false);
            TutorialCanvas.SetActive(false);
            imageObjectif.SetActive(true);
            TexteObjectif.text = "Faire fondre le fer au Four";
            texteObjectif.SetActive(true);
            Fleche.SetActive(true);
            GameObject.Find("Main Camera").GetComponent<CameraMove>().enabled = true;
            GameObject.Find("Main Camera").GetComponent<ObjectClicker>().enabled = true;
            tutoStep = 3;
        }
        if(PlaquesFer >= 10 && tutoStep == 3)
        {
            GameObject.Find("Main Camera").GetComponent<CameraMove>().enabled = false;
            GameObject.Find("Main Camera").GetComponent<ObjectClicker>().enabled = false;
            Jeanne.GetComponent<Image>().sprite = jeanne1;
            Fleche.SetActive(false);
            TutorialCanvas.SetActive(true);
            imageObjectif.SetActive(false);
            texteObjectif.SetActive(false);
            tuto3.SetActive(true);
            tutoStep = 4;
        }
        if (Input.GetMouseButtonDown(0) && tutoStep == 4)
        {
            tutoStep = 5;
            tuto3.SetActive(false);
            TutorialCanvas.SetActive(false);
            imageObjectif.SetActive(true);
            TexteObjectif.text = "Consruis la Découpeuse";
            texteObjectif.SetActive(true);
            Fleche.transform.position = new Vector3(-5.52f, -1.12f, -0.49f);
            Fleche.SetActive(true);
            GameObject.Find("Main Camera").GetComponent<CameraMove>().enabled = true;
            GameObject.Find("Main Camera").GetComponent<ObjectClicker>().enabled = true;
        }
        if (decoupeuse == true && tutoStep == 5)
        {
            GameObject.Find("Main Camera").GetComponent<CameraMove>().enabled = false;
            GameObject.Find("Main Camera").GetComponent<ObjectClicker>().enabled = false;
            Jeanne.GetComponent<Image>().sprite = jeanne2;
            Fleche.SetActive(false);
            TutorialCanvas.SetActive(true);
            imageObjectif.SetActive(false);
            texteObjectif.SetActive(false);
            tuto4.SetActive(true);
            tutoStep = 6;
        }
        if (Input.GetMouseButtonDown(0) && tutoStep == 6)
        {
            Jeanne.GetComponent<Image>().sprite = jeanne1;
            tuto4.SetActive(false);
            tuto5.SetActive(true);
            FlecheCanvas.SetActive(true);
            tutoStep = 7;
            timergo = true;
        }
        if (Input.GetMouseButtonDown(0) && tutoStep == 7 && Timer >= 5)
        {
            timergo = false;
            tutoStep = 8;
            FlecheCanvas.SetActive(false);
            tuto5.SetActive(false);
            TutorialCanvas.SetActive(false);
            imageObjectif.SetActive(true);
            TexteObjectif.text = "Découpe ces premiers flans";
            texteObjectif.SetActive(true);
            Fleche.transform.position = new Vector3(1.79f, 1.7f, 6.05f);
            Fleche.SetActive(true);
            GameObject.Find("Main Camera").GetComponent<CameraMove>().enabled = true;
            GameObject.Find("Main Camera").GetComponent<ObjectClicker>().enabled = true;
        }
        if(FlanCuivre >= 5 && tutoStep == 8)
        {
            GameObject.Find("Main Camera").GetComponent<CameraMove>().enabled = false;
            GameObject.Find("Main Camera").GetComponent<ObjectClicker>().enabled = false;
            Jeanne.GetComponent<Image>().sprite = jeanne3;
            Fleche.SetActive(false);
            TutorialCanvas.SetActive(true);
            imageObjectif.SetActive(false);
            texteObjectif.SetActive(false);
            tuto6.SetActive(true);
            tutoStep = 9;
        }
        if (Input.GetMouseButtonDown(0) && tutoStep == 9)
        {
            tutoStep = 10;
            tuto6.SetActive(false);
            TutorialCanvas.SetActive(false);
            imageObjectif.SetActive(true);
            TexteObjectif.text = "Construis la Mouleuse de Cuivre";
            texteObjectif.SetActive(true);
            Fleche.transform.position = new Vector3(-5.52f, -1.12f, -0.49f);
            Fleche.SetActive(true);
            GameObject.Find("Main Camera").GetComponent<CameraMove>().enabled = true;
            GameObject.Find("Main Camera").GetComponent<ObjectClicker>().enabled = true;
        }
        if (mouleuseCruivre == true && tutoStep == 10)
        {
            GameObject.Find("Main Camera").GetComponent<CameraMove>().enabled = false;
            GameObject.Find("Main Camera").GetComponent<ObjectClicker>().enabled = false;
            Jeanne.GetComponent<Image>().sprite = jeanne1;
            Fleche.SetActive(false);
            TutorialCanvas.SetActive(true);
            imageObjectif.SetActive(false);
            texteObjectif.SetActive(false);
            tuto7.SetActive(true);
            tutoStep = 11;
        }
        if (Input.GetMouseButtonDown(0) && tutoStep == 11)
        {
            tutoStep = 12;
            tuto7.SetActive(false);
            TutorialCanvas.SetActive(false);
            imageObjectif.SetActive(true);
            TexteObjectif.text = "Moule tes premières pieces";
            texteObjectif.SetActive(true);
            Fleche.transform.position = new Vector3(-10.96f, -1.12f, -9.31f);
            Fleche.SetActive(true);
            GameObject.Find("Main Camera").GetComponent<CameraMove>().enabled = true;
            GameObject.Find("Main Camera").GetComponent<ObjectClicker>().enabled = true;
        }
        if (PiecesCuivre >= 5 && tutoStep == 12)
        {
            GameObject.Find("Main Camera").GetComponent<CameraMove>().enabled = false;
            GameObject.Find("Main Camera").GetComponent<ObjectClicker>().enabled = false;
            Jeanne.GetComponent<Image>().sprite = jeanne3;
            Fleche.SetActive(false);
            TutorialCanvas.SetActive(true);
            imageObjectif.SetActive(false);
            texteObjectif.SetActive(false);
            tuto8.SetActive(true);
            tutoStep = 13;
        }
        if (Input.GetMouseButtonDown(0) && tutoStep == 13)
        {
            Jeanne.GetComponent<Image>().sprite = jeanne2;
            tuto8.SetActive(false);
            tuto9.SetActive(true);
            FlecheCanvas2.SetActive(true);
            tutoStep = 14;
            Timer = 0;
            timergo = true;
        }
        if (Input.GetMouseButtonDown(0) && tutoStep == 14 && Timer >= 5)
        {
            tuto9.SetActive(false);
            TutorialCanvas.SetActive(false);
            imageObjectif.SetActive(true);
            TexteObjectif.text = "Fabrique le plus de pièces possibles avant de t'échapper";
            texteObjectif.SetActive(true);
            HUD.GetComponent<Image>().sprite = HUDTimer;
            TimerGame.SetActive(true);
            GameObject.Find("Main Camera").GetComponent<Time>().timerIsRunning = true;
            GameObject.Find("Main Camera").GetComponent<CameraMove>().enabled = true;
            GameObject.Find("Main Camera").GetComponent<ObjectClicker>().enabled = true;
        }

        if (timergo == true)
        {
            Timer = Timer + 0.5f;
        }
    }
    
}