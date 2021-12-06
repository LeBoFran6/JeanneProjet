using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopAnimation : MonoBehaviour
{
    public GameObject anim3D;
    public float time = 0f;
    public bool isOff = false;

    void Update()
    {
        time++;
        if (time >= 150 && isOff == false)
        {
            anim3D.gameObject.GetComponent<Animator>().enabled = false;
            isOff = true;
        }
    }
}
