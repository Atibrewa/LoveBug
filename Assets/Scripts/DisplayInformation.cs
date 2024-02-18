using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DisplayInformation : MonoBehaviour
{
    public TextMeshProUGUI infoDisplay;

    public void changeInfo(string info)
    {
        infoDisplay.text = info;
    }
}
