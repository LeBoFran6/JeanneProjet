using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

[ExecuteInEditMode()]
public class Decoupeuse : MonoBehaviour
{
    public GameObject ScriptHolder;
    public float PlaquesOr;
    public float PlaquesArgent;
    public float PlaquesCuivre;
    public float PlaquesFer;
    public Text TextCuivreC;
    public Text TextArgentC;
    public Text TextOrC;
    public bool IsUsed = false;
    public int Type;
    public float TempsDeCoupe;
    public Text TextCoupe;
    public Slider BarDeProgression;
    public Slider BarDeProgressionInGame;

    public GameObject FlanOr;
    public GameObject FlanArgent;
    public GameObject FlanCuivre;

    public float Flan;
    public GameObject ButtonRecup;
    public Text TextButton;

    public GameObject anim;
    public GameObject anim3D;

    public AudioSource AudioDecoupeuse;

    void Update()
    {
        PlaquesOr = ScriptHolder.GetComponent<ObjectClicker>().PlaquesOr;
        PlaquesArgent = ScriptHolder.GetComponent<ObjectClicker>().PlaquesArgent;
        PlaquesCuivre = ScriptHolder.GetComponent<ObjectClicker>().PlaquesCuivre;
        PlaquesFer = ScriptHolder.GetComponent<ObjectClicker>().PlaquesFer;
        TextCuivreC.text = "" + PlaquesCuivre ;
        TextArgentC.text = "" + PlaquesArgent;
        TextOrC.text = "" + PlaquesOr;

        if (IsUsed == true)
        {
            anim.gameObject.GetComponent<Animator>().enabled = true;
            anim3D.gameObject.GetComponent<Animator>().enabled = true;
            BarDeProgression.value = TempsDeCoupe;
            BarDeProgressionInGame.value = TempsDeCoupe;
            AudioDecoupeuse.Play();

            if (Type == 1)
            {
                if (TempsDeCoupe > 0)
                {
                    TempsDeCoupe = TempsDeCoupe - 0.08f;
                    TextCoupe.text = TempsDeCoupe + "\nFlan";
                }
                if (TempsDeCoupe == 0 || TempsDeCoupe < 0)
                {
                    ButtonRecup.SetActive(true);
                    TextButton.text = "" + Flan;
                    FlanCuivre.SetActive(true);
                    anim.gameObject.GetComponent<Animator>().enabled = false;
                    anim3D.gameObject.GetComponent<Animator>().enabled = false;
                    AudioDecoupeuse.Pause();
                }
            }
            if (Type == 2)
            {
                if (TempsDeCoupe > 0)
                {
                    TempsDeCoupe = TempsDeCoupe - 0.04f;
                    TextCoupe.text = TempsDeCoupe + "\nFlan";
                }
                if (TempsDeCoupe == 0 || TempsDeCoupe < 0)
                {
                    ButtonRecup.SetActive(true);
                    TextButton.text = "" + Flan;
                    FlanArgent.SetActive(true);
                    anim.gameObject.GetComponent<Animator>().enabled = false;
                    anim3D.gameObject.GetComponent<Animator>().enabled = false;
                    AudioDecoupeuse.Pause();
                }
            }
            if (Type == 3)
            {
                if (TempsDeCoupe > 0)
                {
                    TempsDeCoupe = TempsDeCoupe - 0.02f;
                    TextCoupe.text = TempsDeCoupe + "\nFlan";
                }
                if (TempsDeCoupe == 0 || TempsDeCoupe < 0)
                {
                    ButtonRecup.SetActive(true);
                    TextButton.text = "" + Flan;
                    FlanOr.SetActive(true);
                    anim.gameObject.GetComponent<Animator>().enabled = false;
                    anim3D.gameObject.GetComponent<Animator>().enabled = false;
                    AudioDecoupeuse.Pause();
                }
            }

        }
        if (IsUsed == false)
        {
            
            ButtonRecup.SetActive(false);
        }

    }

    public void RecupererFlan()
    {
        GameObject.Find("Main Camera").GetComponent<ObjectClicker>().animIsPlayed = true;
        if (Type == 1)
        {
            ScriptHolder.GetComponent<ObjectClicker>().FlanCuivre += Flan;
        }
        if (Type == 2)
        {
            ScriptHolder.GetComponent<ObjectClicker>().FlanArgent += Flan;
        }
        if (Type == 3)
        {
            ScriptHolder.GetComponent<ObjectClicker>().FlanOr += Flan;
        }
        Flan = 0;
        IsUsed = false;
        FlanCuivre.SetActive(false);
        FlanArgent.SetActive(false);
        FlanOr.SetActive(false);

    }
    public void CouperCuivre()
    {
        if (IsUsed == false)
        {
            if (PlaquesCuivre > 0)
            {
                IsUsed = true;
                Flan = PlaquesCuivre * 50;
                TempsDeCoupe = PlaquesCuivre;
                BarDeProgression.maxValue = TempsDeCoupe;
                BarDeProgression.value = 0;
                BarDeProgressionInGame.maxValue = TempsDeCoupe;
                BarDeProgressionInGame.value = 0;
                ScriptHolder.GetComponent<ObjectClicker>().PlaquesCuivre = 0;
                Type = 1;
            }
        }
    }
    public void CouperArgent()
    {
        if (IsUsed == false)
        {
            if (PlaquesArgent > 0)
            {
                IsUsed = true;
                Flan = PlaquesArgent * 80;
                TempsDeCoupe = PlaquesArgent;
                BarDeProgression.maxValue = TempsDeCoupe;
                BarDeProgression.value = 0;
                BarDeProgressionInGame.maxValue = TempsDeCoupe;
                BarDeProgressionInGame.value = 0;
                ScriptHolder.GetComponent<ObjectClicker>().PlaquesArgent = 0;
                Type = 2;
            }
        }
    }
    public void CouperOr()
    {
        if (IsUsed == false)
        {
            if (PlaquesOr > 0)
            {
                IsUsed = true;
                Flan = PlaquesOr * 100;
                TempsDeCoupe = PlaquesOr;
                BarDeProgression.maxValue = TempsDeCoupe;
                BarDeProgression.value = 0;
                BarDeProgressionInGame.maxValue = TempsDeCoupe;
                BarDeProgressionInGame.value = 0;
                ScriptHolder.GetComponent<ObjectClicker>().PlaquesOr = 0;
                Type = 3;
            }
        }
    }

}
