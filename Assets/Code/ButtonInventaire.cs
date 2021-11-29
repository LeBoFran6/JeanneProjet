using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System;

public class ButtonInventaire : MonoBehaviour
{
    public Button Button;
    public Sprite ferme;
    public Sprite ouvert;
    public GameObject inventaire;
    public bool isOn = false;

    public void InventaireButton()
    {
         if(isOn==false)
         {
             Button.image.sprite = ouvert;
             inventaire.SetActive(true);
             isOn = true;
             GameObject.Find("Main Camera").GetComponent<CameraMove>().enabled = false;
        }
         else
         {
            Button.image.sprite = ferme;
            inventaire.SetActive(false);
            isOn = false;
            GameObject.Find("Main Camera").GetComponent<CameraMove>().enabled = true;
         }
    }
}
