using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectClicker : MonoBehaviour {

    public GameObject CanvasAtelier;
    public GameObject CanvasFour;
    public GameObject CanvasDecoupeuse;
    public GameObject CanvasMouleuseCuivre;
    public GameObject CanvasMouleuseArgent;
    public GameObject CanvasMouleuseOr;
    public GameObject Or1;
    public GameObject Or2;
    public GameObject Or3;
    public GameObject Or4;
    public GameObject Or5;
    public GameObject Or6;
    public GameObject Argent1;
    public GameObject Argent2;
    public GameObject Argent3;
    public GameObject Argent4;
    public GameObject Argent5;
    public GameObject Argent6;
    public GameObject Cuivre1;
    public GameObject Cuivre2;
    public GameObject Cuivre3;
    public GameObject Cuivre4;
    public GameObject Cuivre5;
    public GameObject Cuivre6;
    public GameObject Fer1;
    public GameObject Fer2;
    public GameObject Fer3;
    public GameObject Fer4;
    public GameObject Fer5;
    public GameObject Fer6;
    public Text TextOrC;
    public float OrC;
    public Text TextArgentC;
    public float ArgentC;
    public Text TextCuivreC;
    public float CuivreC;
    public Text TextFerC;
    public float FerC;
    public Text TextPlaquesFer;
    public float PlaquesFer = 0;
    public Text TextPlaquesCuivre;
    public float PlaquesCuivre = 0;
    public Text TextPlaquesArgent;
    public float PlaquesArgent = 0;
    public Text TextPlaquesOr;
    public float PlaquesOr = 0;
    public Text TextFlanCuivre;
    public float FlanCuivre = 0;
    public Text TextFlanArgent;
    public float FlanArgent = 0;
    public Text TextFlanOr;
    public float FlanOr = 0;
    public Text TextPiecesCuivre;
    public float PiecesCuivre = 0;
    public Text TextPiecesArgent;
    public float PiecesArgent = 0;
    public Text TextPiecesOr;
    public float PiecesOr = 0;

    public float time = 0;

    public GameObject HUD;
    public GameObject CanvasWin;
    public Text ScoreTextPiecesOr;
    public Text ScoreTextPiecesArgent;
    public Text ScoreTextPiecesCuivre;

    public GameObject anim;
    public bool animIsPlayed = false;

    private void Update()
    {
        TextFerC.text = FerC + " g";
        TextCuivreC.text = CuivreC + " g";
        TextArgentC.text = ArgentC + " g";
        TextOrC.text = OrC + " g";
        TextPlaquesFer.text = "" + PlaquesFer ;
        TextPlaquesCuivre.text = "" + PlaquesCuivre ;
        TextPlaquesArgent.text = "" + PlaquesArgent ;
        TextPlaquesOr.text = "" + PlaquesOr ;
        TextFlanCuivre.text = "" + FlanCuivre;
        TextFlanArgent.text = "" + FlanArgent;
        TextFlanOr.text = "" + FlanOr;
        TextPiecesCuivre.text = "" + PiecesCuivre;
        TextPiecesArgent.text = "" + PiecesArgent;
        TextPiecesOr.text = "" + PiecesOr;

        ScoreTextPiecesCuivre.text = "" + PiecesCuivre;
        ScoreTextPiecesArgent.text = "" + PiecesArgent;
        ScoreTextPiecesOr.text = "" + PiecesOr;

        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit, 100.0f))
            {
                Debug.Log(hit.transform.gameObject.name);


                if (hit.transform.gameObject.name == "Charette")
                {
                    HUD.SetActive(false);
                    GameObject.Find("Main Camera").GetComponent<Time>().timerIsRunning = false;
                    GameObject.Find("Main Camera").GetComponent<CameraMove>().enabled = false;
                    GameObject.Find("Main Camera").GetComponent<ObjectClicker>().enabled = false;
                    CanvasWin.SetActive(true);
                }

                if (hit.transform.gameObject.name == "Atelier")
                {
                    CanvasAtelier.SetActive(true);
                    GameObject.Find("Main Camera").GetComponent<CameraMove>().enabled = false;
                    GameObject.Find("Main Camera").GetComponent<ObjectClicker>().enabled = false;
                    GameObject.Find("Tutorial").GetComponent<Tutorial>().enabled = false;
                }
                if (hit.transform.gameObject.name == "Four")
                {
                    CanvasFour.SetActive(true);
                    GameObject.Find("Main Camera").GetComponent<CameraMove>().enabled = false;
                    GameObject.Find("Main Camera").GetComponent<ObjectClicker>().enabled = false;
                    GameObject.Find("Tutorial").GetComponent<Tutorial>().enabled = false;
                }
                if (hit.transform.gameObject.name == "Decoupeuse")
                {
                    CanvasDecoupeuse.SetActive(true);
                    GameObject.Find("Main Camera").GetComponent<CameraMove>().enabled = false;
                    GameObject.Find("Main Camera").GetComponent<ObjectClicker>().enabled = false;
                    GameObject.Find("Tutorial").GetComponent<Tutorial>().enabled = false;
                }
                if (hit.transform.gameObject.name == "MouleuseCuivre")
                {
                    CanvasMouleuseCuivre.SetActive(true);
                    GameObject.Find("Main Camera").GetComponent<CameraMove>().enabled = false;
                    GameObject.Find("Main Camera").GetComponent<ObjectClicker>().enabled = false;
                    GameObject.Find("Tutorial").GetComponent<Tutorial>().enabled = false;
                }
                if (hit.transform.gameObject.name == "MouleuseArgent")
                {
                    CanvasMouleuseArgent.SetActive(true);
                    GameObject.Find("Main Camera").GetComponent<CameraMove>().enabled = false;
                    GameObject.Find("Main Camera").GetComponent<ObjectClicker>().enabled = false;
                }
                if (hit.transform.gameObject.name == "MouleuseOr")
                {
                    CanvasMouleuseOr.SetActive(true);
                    GameObject.Find("Main Camera").GetComponent<CameraMove>().enabled = false;
                    GameObject.Find("Main Camera").GetComponent<ObjectClicker>().enabled = false;
                }

                if (hit.transform.gameObject.name == "Or1")
                {
                    Or1.SetActive(false);
                    OrC = OrC + 300;
                    TextOrC.text = OrC + " g";
                    GameObject.Find("Object (1)").GetComponent<ObjectRespawn>().enabled = true;
                    GameObject.Find("Object (1)").GetComponent<ObjectRespawn>().StartTimer();
                    anim.gameObject.GetComponent<Animator>().enabled = true;
                    animIsPlayed = true;
                }
                if (hit.transform.gameObject.name == "Or2")
                {
                    Or2.SetActive(false);
                    OrC = OrC + 500;
                    TextOrC.text = OrC + " g";
                    GameObject.Find("Object (2)").GetComponent<ObjectRespawn>().enabled = true;
                    GameObject.Find("Object (2)").GetComponent<ObjectRespawn>().StartTimer();
                }
                if (hit.transform.gameObject.name == "Or3")
                {
                    Or3.SetActive(false);
                    OrC = OrC + 1000;
                    TextOrC.text = OrC + " g";
                    GameObject.Find("Object (3)").GetComponent<ObjectRespawn>().enabled = true;
                    GameObject.Find("Object (3)").GetComponent<ObjectRespawn>().StartTimer();
                }
                if (hit.transform.gameObject.name == "Or4")
                {
                    Or4.SetActive(false);
                    OrC = OrC + 300;
                    TextOrC.text = OrC + " g";
                    GameObject.Find("Object (4)").GetComponent<ObjectRespawn>().enabled = true;
                    GameObject.Find("Object (4)").GetComponent<ObjectRespawn>().StartTimer();
                }
                if (hit.transform.gameObject.name == "Or5")
                {
                    Or5.SetActive(false);
                    OrC = OrC + 500;
                    TextOrC.text = OrC + " g";
                    GameObject.Find("Object (5)").GetComponent<ObjectRespawn>().enabled = true;
                    GameObject.Find("Object (5)").GetComponent<ObjectRespawn>().StartTimer();
                }
                if (hit.transform.gameObject.name == "Or6")
                {
                    Or6.SetActive(false);
                    OrC = OrC + 1000;
                    TextOrC.text = OrC + " g";
                    GameObject.Find("Object (6)").GetComponent<ObjectRespawn>().enabled = true;
                    GameObject.Find("Object (6)").GetComponent<ObjectRespawn>().StartTimer();
                }
                if (hit.transform.gameObject.name == "Argent1")
                {
                    Argent1.SetActive(false);
                    ArgentC = ArgentC + 300;
                    TextArgentC.text = ArgentC + " g";
                    GameObject.Find("Object (7)").GetComponent<ObjectRespawn>().enabled = true;
                    GameObject.Find("Object (7)").GetComponent<ObjectRespawn>().StartTimer();
                }
                if (hit.transform.gameObject.name == "Argent2")
                {
                    Argent2.SetActive(false);
                    ArgentC = ArgentC + 500;
                    TextArgentC.text = ArgentC + " g";
                    GameObject.Find("Object (8)").GetComponent<ObjectRespawn>().enabled = true;
                    GameObject.Find("Object (8)").GetComponent<ObjectRespawn>().StartTimer();
                }
                if (hit.transform.gameObject.name == "Argent3")
                {
                    Argent3.SetActive(false);
                    ArgentC = ArgentC + 1000;
                    TextArgentC.text = ArgentC + " g";
                    GameObject.Find("Object (9)").GetComponent<ObjectRespawn>().enabled = true;
                    GameObject.Find("Object (9)").GetComponent<ObjectRespawn>().StartTimer();
                }
                if (hit.transform.gameObject.name == "Argent4")
                {
                    Argent4.SetActive(false);
                    ArgentC = ArgentC + 300;
                    TextArgentC.text = ArgentC + " g";
                    GameObject.Find("Object (10)").GetComponent<ObjectRespawn>().enabled = true;
                    GameObject.Find("Object (10)").GetComponent<ObjectRespawn>().StartTimer();
                }
                if (hit.transform.gameObject.name == "Argent5")
                {
                    Argent5.SetActive(false);
                    ArgentC = ArgentC + 500;
                    TextArgentC.text = ArgentC + " g";
                    GameObject.Find("Object (11)").GetComponent<ObjectRespawn>().enabled = true;
                    GameObject.Find("Object (11)").GetComponent<ObjectRespawn>().StartTimer();
                }
                if (hit.transform.gameObject.name == "Argent6")
                {
                    Argent6.SetActive(false);
                    ArgentC = ArgentC + 1000;
                    TextArgentC.text = ArgentC + " g";
                    GameObject.Find("Object (12)").GetComponent<ObjectRespawn>().enabled = true;
                    GameObject.Find("Object (12)").GetComponent<ObjectRespawn>().StartTimer();
                }
                if (hit.transform.gameObject.name == "Cuivre1")
                {
                    Cuivre1.SetActive(false);
                    CuivreC = CuivreC + 300;
                    TextCuivreC.text = CuivreC + " g";
                    GameObject.Find("Object (13)").GetComponent<ObjectRespawn>().enabled = true;
                    GameObject.Find("Object (13)").GetComponent<ObjectRespawn>().StartTimer();
                }
                if (hit.transform.gameObject.name == "Cuivre2")
                {
                    Cuivre2.SetActive(false);
                    CuivreC = CuivreC + 500;
                    TextCuivreC.text = CuivreC + " g";
                    GameObject.Find("Object (14)").GetComponent<ObjectRespawn>().enabled = true;
                    GameObject.Find("Object (14)").GetComponent<ObjectRespawn>().StartTimer();
                }
                if (hit.transform.gameObject.name == "Cuivre3")
                {
                    Cuivre3.SetActive(false);
                    CuivreC = CuivreC + 1000;
                    TextCuivreC.text = CuivreC + " g";
                    GameObject.Find("Object (15)").GetComponent<ObjectRespawn>().enabled = true;
                    GameObject.Find("Object (15)").GetComponent<ObjectRespawn>().StartTimer();
                }
                if (hit.transform.gameObject.name == "Cuivre4")
                {
                    Cuivre4.SetActive(false);
                    CuivreC = CuivreC + 300;
                    TextCuivreC.text = CuivreC + " g";
                    GameObject.Find("Object (16)").GetComponent<ObjectRespawn>().enabled = true;
                    GameObject.Find("Object (16)").GetComponent<ObjectRespawn>().StartTimer();
                }
                if (hit.transform.gameObject.name == "Cuivre5")
                {
                    Cuivre5.SetActive(false);
                    CuivreC = CuivreC + 500;
                    TextCuivreC.text = CuivreC + " g";
                    GameObject.Find("Object (17)").GetComponent<ObjectRespawn>().enabled = true;
                    GameObject.Find("Object (17)").GetComponent<ObjectRespawn>().StartTimer();
                }
                if (hit.transform.gameObject.name == "Cuivre6")
                {
                    Cuivre6.SetActive(false);
                    CuivreC = CuivreC + 1000;
                    TextCuivreC.text = CuivreC + " g";
                    GameObject.Find("Object (18)").GetComponent<ObjectRespawn>().enabled = true;
                    GameObject.Find("Object (18)").GetComponent<ObjectRespawn>().StartTimer();
                }
                if (hit.transform.gameObject.name == "Fer1")
                {
                    Fer1.SetActive(false);
                    FerC = FerC + 300;
                    TextFerC.text = FerC + " g";
                    GameObject.Find("Object (19)").GetComponent<ObjectRespawn>().enabled = true;
                    GameObject.Find("Object (19)").GetComponent<ObjectRespawn>().StartTimer();
                }
                if (hit.transform.gameObject.name == "Fer2")
                {
                    Fer2.SetActive(false);
                    FerC = FerC + 500;
                    TextFerC.text = FerC + " g";
                    GameObject.Find("Object (20)").GetComponent<ObjectRespawn>().enabled = true;
                    GameObject.Find("Object (20)").GetComponent<ObjectRespawn>().StartTimer();
                }
                if (hit.transform.gameObject.name == "Fer3")
                {
                    Fer3.SetActive(false);
                    FerC = FerC + 1000;
                    TextFerC.text = FerC + " g";
                    GameObject.Find("Object (21)").GetComponent<ObjectRespawn>().enabled = true;
                    GameObject.Find("Object (21)").GetComponent<ObjectRespawn>().StartTimer();
                }
                if (hit.transform.gameObject.name == "Fer4")
                {
                    Fer4.SetActive(false);
                    FerC = FerC + 300;
                    TextFerC.text = FerC + " g";
                    GameObject.Find("Object (22)").GetComponent<ObjectRespawn>().enabled = true;
                    GameObject.Find("Object (22)").GetComponent<ObjectRespawn>().StartTimer();
                }
                if (hit.transform.gameObject.name == "Fer5")
                {
                    Fer5.SetActive(false);
                    FerC = FerC + 500;
                    TextFerC.text = FerC + " g";
                    GameObject.Find("Object (23)").GetComponent<ObjectRespawn>().enabled = true;
                    GameObject.Find("Object (23)").GetComponent<ObjectRespawn>().StartTimer();
                }
                if (hit.transform.gameObject.name == "Fer6")
                {
                    Fer6.SetActive(false);
                    FerC = FerC + 1000;
                    TextFerC.text = FerC + " g";
                    GameObject.Find("Object (24)").GetComponent<ObjectRespawn>().enabled = true;
                    GameObject.Find("Object (24)").GetComponent<ObjectRespawn>().StartTimer();
                }
               
            }
        }

        if (animIsPlayed == true)
        {
            time++;
            if (time >= 100)
            {
                time = 0;
                anim.gameObject.GetComponent<Animator>().enabled = false;
                animIsPlayed = false;
            }
        }

    }
}
