using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class LEDebug : MonoBehaviour
{
    public Text eventSystemText;

    private void Update()
    {
        if (eventSystemText)
            eventSystemText.text = EventSystem.current.ToString();
    }
}
