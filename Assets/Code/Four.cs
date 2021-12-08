using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode()]
public class Four : MonoBehaviour
{
    public GameObject ScriptHolder;
    public float Or;
    public float Argent;
    public float Cuivre;
    public float Fer;
    public Text TextFerC;
    public Text TextCuivreC;
    public Text TextArgentC;
    public Text TextOrC;
    public bool IsUsed = false;
    public int Type;
    public float TempsDeFonte;
    public Text TextFonte;
    public Slider BarDeProgression;
    public Slider BarDeProgressionInGame;

    public GameObject PlaquesOr;
    public GameObject PlaquesArgent;
    public GameObject PlaquesCuivre;
    public GameObject PlaquesFer;

    public float Plaques;
    public GameObject ButtonRecup;
    public Text TextButton;

    public Image four;
    public Sprite noAnim;
    public GameObject anim;
    public GameObject anim3D;

    void Update()
    {
        Or = ScriptHolder.GetComponent<ObjectClicker>().OrC;
        Argent = ScriptHolder.GetComponent<ObjectClicker>().ArgentC;
        Cuivre = ScriptHolder.GetComponent<ObjectClicker>().CuivreC;
        Fer = ScriptHolder.GetComponent<ObjectClicker>().FerC;
        TextFerC.text = Fer + " g";
        TextCuivreC.text = Cuivre + " g";
        TextArgentC.text = Argent + " g";
        TextOrC.text = Or + " g";

         if(IsUsed == true)
         {
            anim.gameObject.GetComponent<Animator>().enabled = true;
            anim3D.gameObject.GetComponent<Animator>().enabled = true;
            BarDeProgression.value = TempsDeFonte;
            BarDeProgressionInGame.value = TempsDeFonte;

            if (Type == 1)
            {
                if (TempsDeFonte > 0)
                {
                    TempsDeFonte = TempsDeFonte - 8f;
                    TextFonte.text = TempsDeFonte + " g";
                }
                if (TempsDeFonte == 0 || TempsDeFonte < 0)
                {
                    ButtonRecup.SetActive(true);
                    TextButton.text = "" + Plaques;
                    PlaquesFer.SetActive(true);
                    anim.gameObject.GetComponent<Animator>().enabled = false;
                    four.sprite = noAnim;
                    anim3D.gameObject.GetComponent<Animator>().enabled = false;
                }
            }
            if (Type == 2)
            {
                if (TempsDeFonte > 0)
                {
                    TempsDeFonte = TempsDeFonte - 4f;
                    TextFonte.text = TempsDeFonte + " g";
                }
                if (TempsDeFonte == 0 || TempsDeFonte < 0)
                {
                    ButtonRecup.SetActive(true);
                    TextButton.text = "" + Plaques;
                    PlaquesCuivre.SetActive(true);
                    anim.gameObject.GetComponent<Animator>().enabled = false;
                    four.sprite = noAnim;
                    anim3D.gameObject.GetComponent<Animator>().enabled = false;
                }
            }
            if (Type == 3)
            {
                if (TempsDeFonte > 0)
                {
                    TempsDeFonte = TempsDeFonte - 2f;
                    TextFonte.text = TempsDeFonte + " g";
                }
                if (TempsDeFonte == 0 || TempsDeFonte < 0)
                {
                    ButtonRecup.SetActive(true);
                    TextButton.text = "" + Plaques;
                    PlaquesArgent.SetActive(true);
                    anim.gameObject.GetComponent<Animator>().enabled = false;
                    four.sprite = noAnim;
                    anim3D.gameObject.GetComponent<Animator>().enabled = false;
                }
            }
            if (Type == 4)
            {
                if (TempsDeFonte > 0)
                {
                    TempsDeFonte = TempsDeFonte - 0.5f;
                    TextFonte.text = TempsDeFonte + " g";
                }
                if (TempsDeFonte == 0 || TempsDeFonte < 0)
                {
                    ButtonRecup.SetActive(true);
                    TextButton.text = "" + Plaques;
                    PlaquesOr.SetActive(true);
                    anim.gameObject.GetComponent<Animator>().enabled = false;
                    four.sprite = noAnim;
                    anim3D.gameObject.GetComponent<Animator>().enabled = false;
                }
            }

        }
         if(IsUsed == false)
         {
            ButtonRecup.SetActive(false);
        }

    }

    public void RecupererPlaques()
    {
        GameObject.Find("Main Camera").GetComponent<ObjectClicker>().animIsPlayed = true;
        if (Type == 1)
        {
            ScriptHolder.GetComponent<ObjectClicker>().PlaquesFer += Plaques;
        }
        if (Type == 2)
        {
            ScriptHolder.GetComponent<ObjectClicker>().PlaquesCuivre += Plaques;
        }
        if (Type == 3)
        {
            ScriptHolder.GetComponent<ObjectClicker>().PlaquesArgent += Plaques;
        }
        if (Type == 4)
        {
            ScriptHolder.GetComponent<ObjectClicker>().PlaquesOr += Plaques;
        }
        Plaques = 0;
        IsUsed = false;
        PlaquesFer.SetActive(false);
        PlaquesCuivre.SetActive(false);
        PlaquesArgent.SetActive(false);
        PlaquesOr.SetActive(false);

    }
    public void FondreFer()
    {
        if (IsUsed == false)
        {
            if (Fer > 0)
            {
                IsUsed = true;
                Plaques = Fer / 100;
                TempsDeFonte = Fer;
                BarDeProgression.maxValue = TempsDeFonte;
                BarDeProgression.value = 0;
                BarDeProgressionInGame.maxValue = TempsDeFonte;
                BarDeProgressionInGame.value = 0;
                ScriptHolder.GetComponent<ObjectClicker>().FerC = 0;
                Type = 1;
            }
        }
    }
    public void FondreCuivre()
    {
        if (IsUsed == false)
        {
            if (Cuivre > 0)
            {
                IsUsed = true;
                Plaques = Cuivre / 100;
                TempsDeFonte = Cuivre;
                BarDeProgression.maxValue = TempsDeFonte;
                BarDeProgression.value = 0;
                BarDeProgressionInGame.maxValue = TempsDeFonte;
                BarDeProgressionInGame.value = 0;
                ScriptHolder.GetComponent<ObjectClicker>().CuivreC = 0;
                Type = 2;
            }
        }
    }
    public void FondreArgent()
    {
        if (IsUsed == false)
        {
            if (Argent > 0)
            {
                IsUsed = true;
                Plaques = Argent / 100;
                TempsDeFonte = Argent;
                BarDeProgression.maxValue = TempsDeFonte;
                BarDeProgression.value = 0;
                BarDeProgressionInGame.maxValue = TempsDeFonte;
                BarDeProgressionInGame.value = 0;
                ScriptHolder.GetComponent<ObjectClicker>().ArgentC = 0;
                Type = 3;
            }
        }
    }
    public void FondreOr()
    {
        if (IsUsed == false)
        {
            if (Or > 0)
            {
                IsUsed = true;
                Plaques = Or / 100;
                TempsDeFonte = Or;
                BarDeProgression.maxValue = TempsDeFonte;
                BarDeProgression.value = 0;
                BarDeProgressionInGame.maxValue = TempsDeFonte;
                BarDeProgressionInGame.value = 0;
                ScriptHolder.GetComponent<ObjectClicker>().OrC = 0;
                Type = 4;
            }
        }
    }



}
