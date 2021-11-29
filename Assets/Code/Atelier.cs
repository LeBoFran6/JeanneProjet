using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Atelier : MonoBehaviour
{
    public GameObject ScriptHolder;
    public float PiecesArgent;
    public float PiecesCuivre;
    public float PlaquesFer;
    public GameObject ButtonDecoupeuse;
    public GameObject Decoupeuse;
    public GameObject ButtonMouleuseCuivre;
    public GameObject MouleuseCuivre;
    public GameObject ButtonMouleuseArgent;
    public GameObject MouleuseArgent;
    public GameObject ButtonMouleuseOr;
    public GameObject MouleuseOr;
    public bool decoupeuse = false;
    public bool mouleuseCruivre = false;

    public Button Buy1;
    public Button Buy2;
    public Button Buy3;
    public Button Buy4;

    public Sprite cantBuy;
    public Sprite canBuy;

    public Text textD1;
    public Text textM1;
    public Text textM2_1;
    public Text textM2_2;
    public Text textM3_1;
    public Text textM3_2;

    void Update()
    {
        PiecesArgent = ScriptHolder.GetComponent<ObjectClicker>().PiecesArgent;
        PiecesCuivre = ScriptHolder.GetComponent<ObjectClicker>().PiecesCuivre;
        PlaquesFer = ScriptHolder.GetComponent<ObjectClicker>().PlaquesFer;

        textD1.text = ""+PlaquesFer;
        textM1.text = "" + PlaquesFer;
        textM2_1.text = "" + PlaquesFer;
        textM2_2.text = "" + PiecesCuivre;
        textM3_1.text = "" + PlaquesFer;
        textM3_2.text = "" + PiecesArgent;


        if(PlaquesFer >= 10)
        {
            textD1.color = new Color(0, 0, 0, 255);
            Buy1.image.sprite = canBuy;
        }
        else
        {
            textD1.color = new Color(255, 0, 0, 255);
            Buy1.image.sprite = cantBuy;
        }

        if (PlaquesFer >= 20)
        {
            textM1.color = new Color(0, 0, 0, 255);
            Buy2.image.sprite = canBuy;
        }
        else
        {
            textM1.color = new Color(255, 0, 0, 255);
            Buy2.image.sprite = cantBuy;
        }

        if (PlaquesFer >= 25)
        {
            textM2_1.color = new Color(0, 0, 0, 255);
        }
        else
        {
            textM2_1.color = new Color(255, 0, 0, 255);
        }

        if (PiecesCuivre >= 1000)
        {
            textM2_2.color = new Color(0, 0, 0, 255);
        }
        else
        {
            textM2_2.color = new Color(255, 0, 0, 255);
        }

        if (PlaquesFer >= 30)
        {
            textM3_1.color = new Color(0, 0, 0, 255);
        }
        else
        {
            textM3_1.color = new Color(255, 0, 0, 255);
        }

        if (PiecesCuivre >= 1700)
        {
            textM3_2.color = new Color(0, 0, 0, 255);
        }
        else
        {
            textM3_2.color = new Color(255, 0, 0, 255);
        }

        if (PlaquesFer >= 25 && PiecesCuivre >= 1000)
        {
            Buy3.image.sprite = canBuy;
        }
        else
        {
            Buy3.image.sprite = cantBuy;
        }

        if (PlaquesFer >= 30 && PiecesArgent >= 1700)
        {
            Buy4.image.sprite = canBuy;
        }
        else
        {
            Buy4.image.sprite = cantBuy;
        }
    }


    
    public void AcheterDecoupeuse()
    {
        if(PlaquesFer == 10 || PlaquesFer > 10)
        {
            decoupeuse = true;
            Decoupeuse.SetActive(true);
            ScriptHolder.GetComponent<ObjectClicker>().PlaquesFer -= 10;
            ButtonDecoupeuse.SetActive(false);
        }
    }
    public void AcheterMouleuseCuivre()
    {
        if (PlaquesFer == 20 || PlaquesFer > 20)
        {
            mouleuseCruivre = true;
            MouleuseCuivre.SetActive(true);
            ScriptHolder.GetComponent<ObjectClicker>().PlaquesFer -= 20;
            ButtonMouleuseCuivre.SetActive(false);
        }
    }
    public void AcheterMouleuseArgent()
    {
        if (PlaquesFer == 25 || PlaquesFer > 25 && PiecesCuivre == 1000 || PiecesCuivre > 1000)
        {
            MouleuseArgent.SetActive(true);
            ScriptHolder.GetComponent<ObjectClicker>().PlaquesFer -= 25;
            ScriptHolder.GetComponent<ObjectClicker>().PiecesCuivre -= 1000;
            ButtonMouleuseArgent.SetActive(false);
        }
    }
    public void AcheterMouleuseOr()
    {
        if (PlaquesFer == 30 || PlaquesFer > 30 && PiecesArgent == 1700 || PiecesArgent > 1700)
        {
            MouleuseOr.SetActive(true);
            ScriptHolder.GetComponent<ObjectClicker>().PlaquesFer -= 30;
            ScriptHolder.GetComponent<ObjectClicker>().PiecesArgent -= 1700;
            ButtonMouleuseOr.SetActive(false);
        }
    }
}
