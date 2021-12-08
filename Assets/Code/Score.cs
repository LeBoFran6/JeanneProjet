using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public GameObject ScriptCamera;

    public Image ImageRank;

    public Sprite R2;
    public Sprite R3;
    public Sprite R4;
    public Sprite R5;
    public Sprite R6;
    public Sprite R7;
    public Sprite R8;
    public Sprite R9;

    public Text TotalScore;
    public float TotalPieces;

    public float Cuivre;
    public float Argent;
    public float Or;


    // Update is called once per frame
    void Update()
    {
        Cuivre = ScriptCamera.GetComponent<ObjectClicker>().PiecesCuivre;
        Argent = ScriptCamera.GetComponent<ObjectClicker>().PiecesArgent;
        Or = ScriptCamera.GetComponent<ObjectClicker>().PiecesOr;

        TotalPieces = Cuivre + Argent * 2 + Or * 4;

        TotalScore.text = "Score : " + TotalPieces;

        if (TotalPieces > 10000)
        {
            ImageRank.sprite = R2;
        }
        if (TotalPieces > 20000)
        {
            ImageRank.sprite = R3;
        }
        if (TotalPieces > 30000)
        {
            ImageRank.sprite = R4;
        }
        if (TotalPieces > 40000)
        {
            ImageRank.sprite = R5;
        }
        if (TotalPieces > 45000)
        {
            ImageRank.sprite = R6;
        }
        if (TotalPieces > 50000)
        {
            ImageRank.sprite = R7;
        }
        if (TotalPieces > 55000)
        {
            ImageRank.sprite = R8;
        }
        if (TotalPieces > 60000)
        {
            ImageRank.sprite = R9;
        }


    }
}
