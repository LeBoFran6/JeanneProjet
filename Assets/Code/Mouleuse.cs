using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[ExecuteInEditMode()]
public class Mouleuse : MonoBehaviour
{
    public GameObject ScriptHolder;
    public float Flan;
    public Text TextQuantite;
    public bool IsUsed = false;
    public int Type;
    public float TempsDeMoulage;
    public Text TextMoulage;
    public Slider BarreDeProgression;
    public Slider BarreDeProgressionInGame;

    public float Pieces;
    public GameObject ButtonRecup;
    public Text TextButton;

    public GameObject anim;
    public GameObject anim3D;

    void Update()
    {
        if(Type == 1)
        {
            Flan = ScriptHolder.GetComponent<ObjectClicker>().FlanCuivre;
            TextQuantite.text = "" + Flan;
        }
        if (Type == 2)
        {
            Flan = ScriptHolder.GetComponent<ObjectClicker>().FlanArgent;
            TextQuantite.text = "" + Flan;
        }
        if (Type == 3)
        {
            Flan = ScriptHolder.GetComponent<ObjectClicker>().FlanOr;
            TextQuantite.text = "" + Flan;
        }

        if (IsUsed == true)
        {
            anim.gameObject.GetComponent<Animator>().enabled = true;
            anim3D.gameObject.GetComponent<Animator>().enabled = true;

            BarreDeProgression.value = TempsDeMoulage;
            BarreDeProgressionInGame.value = TempsDeMoulage;

            if (Type == 1)
            {
                if (TempsDeMoulage > 0)
                {
                    TempsDeMoulage = TempsDeMoulage - 3f;
                    TextMoulage.text = TempsDeMoulage + "\nFlan";
                }
                if (TempsDeMoulage == 0 || TempsDeMoulage < 0)
                {
                    ButtonRecup.SetActive(true);
                    TextButton.text = "Recup\nPieces\nCuivre\n" + Pieces;
                    anim.gameObject.GetComponent<Animator>().enabled = false;
                    anim3D.gameObject.GetComponent<Animator>().enabled = false;
                }
            }
            if (Type == 2)
            {
                if (TempsDeMoulage > 0)
                {
                    TempsDeMoulage = TempsDeMoulage - 2f;
                    TextMoulage.text = TempsDeMoulage + "\nFlan";
                }
                if (TempsDeMoulage == 0 || TempsDeMoulage < 0)
                {
                    ButtonRecup.SetActive(true);
                    TextButton.text = "Recup\nPieces\nArgent\n" + Pieces;
                    anim.gameObject.GetComponent<Animator>().enabled = false;
                    anim3D.gameObject.GetComponent<Animator>().enabled = false;
                }
            }
            if (Type == 3)
            {
                if (TempsDeMoulage > 0)
                {
                    TempsDeMoulage = TempsDeMoulage - 1f;
                    TextMoulage.text = TempsDeMoulage + "\nFlan";
                }
                if (TempsDeMoulage == 0 || TempsDeMoulage < 0)
                {
                    ButtonRecup.SetActive(true);
                    TextButton.text = "Recup\nPieces\nOr\n" + Pieces;
                    anim.gameObject.GetComponent<Animator>().enabled = false;
                    anim3D.gameObject.GetComponent<Animator>().enabled = false;
                }
            }

        }
        if (IsUsed == false)
        {
            ButtonRecup.SetActive(false);
        }

    }

    public void RecupererPieces()
    {
        if (Type == 1)
        {
            ScriptHolder.GetComponent<ObjectClicker>().PiecesCuivre += Pieces;
        }
        if (Type == 2)
        {
            ScriptHolder.GetComponent<ObjectClicker>().PiecesArgent += Pieces;
        }
        if (Type == 3)
        {
            ScriptHolder.GetComponent<ObjectClicker>().PiecesOr += Pieces;
        }
        Pieces = 0;
        IsUsed = false;

    }
    public void MoulerCuivre()
    {
        if (IsUsed == false)
        {
            if (Flan > 0 && Type == 1)
            {
                IsUsed = true;
                Pieces = Flan;
                TempsDeMoulage = Pieces;
                BarreDeProgression.maxValue = TempsDeMoulage;
                BarreDeProgression.value = 0;
                BarreDeProgressionInGame.maxValue = TempsDeMoulage;
                BarreDeProgressionInGame.value = 0;
                ScriptHolder.GetComponent<ObjectClicker>().FlanCuivre = 0;
            }
        }
    }
    public void MoulerArgent()
    {
        if (IsUsed == false)
        {
            if (Type == 2)
            {
                IsUsed = true;
                Pieces = Flan;
                TempsDeMoulage = Pieces;
                BarreDeProgression.maxValue = TempsDeMoulage;
                BarreDeProgression.value = 0;
                BarreDeProgressionInGame.maxValue = TempsDeMoulage;
                BarreDeProgressionInGame.value = 0;
                ScriptHolder.GetComponent<ObjectClicker>().FlanArgent = 0;
            }
        }
    }
    public void MoulerOr()
    {
        if (IsUsed == false)
        {
            if (Type == 3)
            {
                IsUsed = true;
                Pieces = Flan;
                TempsDeMoulage = Pieces;
                BarreDeProgression.maxValue = TempsDeMoulage;
                BarreDeProgression.value = 0;
                BarreDeProgressionInGame.maxValue = TempsDeMoulage;
                BarreDeProgressionInGame.value = 0;
                ScriptHolder.GetComponent<ObjectClicker>().FlanOr = 0;
            }
        }
    }

}
