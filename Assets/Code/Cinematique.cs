using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cinematique : MonoBehaviour
{
    public GameObject image;
    public GameObject texte;
    public GameObject button;

    public GameObject image1;
    public GameObject texte1;
    public GameObject button1;

    public GameObject image2;
    public GameObject texte2;
    public GameObject button2;

    public GameObject image3;
    public GameObject texte3;
    public GameObject button3;

    public GameObject image4;
    public GameObject texte4;
    public GameObject button4;

    public GameObject image5;
    public GameObject texte5;
    public GameObject button5;

    public GameObject buttonPasser;

    public void A()
    {
        image.SetActive(false);
        texte.SetActive(false);
        button.SetActive(false);

        image1.SetActive(true);
        texte1.SetActive(true);
        button1.SetActive(true);
    }

    public void B()
    {
        image1.SetActive(false);
        texte1.SetActive(false);
        button1.SetActive(false);

        image2.SetActive(true);
        texte2.SetActive(true);
        button2.SetActive(true);
    }

    public void C()
    {
        image2.SetActive(false);
        texte2.SetActive(false);
        button2.SetActive(false);

        image3.SetActive(true);
        texte3.SetActive(true);
        button3.SetActive(true);
    }

    public void D()
    {
        image3.SetActive(false);
        texte3.SetActive(false);
        button3.SetActive(false);

        image4.SetActive(true);
        texte4.SetActive(true);
        button4.SetActive(true);
    }

    public void E()
    {
        image4.SetActive(false);
        texte4.SetActive(false);
        button4.SetActive(false);
        buttonPasser.SetActive(false);

        image5.SetActive(true);
        texte5.SetActive(true);
        button5.SetActive(true);
    }


}
