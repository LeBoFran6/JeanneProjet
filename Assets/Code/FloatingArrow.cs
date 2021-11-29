using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatingArrow : MonoBehaviour
{
    public GameObject Arrow;
    public float floating = 2;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Arrow.transform.position = new Vector3(floating, 0, 0);

        if (floating >= 2)
        {
            floating--;
        }
        if (floating <= -2)
        {
            floating++;
        }

    }
}
