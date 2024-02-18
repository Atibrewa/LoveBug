using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolUse : MonoBehaviour
{
    public DisplayDiagnostics display;
    string heart;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Stethoscope")
        {
            if (GetComponent<NPC>().heartbeat) {
                heart = "irregular";
            } else {
                heart = "regular";
            }
            display.changeInfo(heart);
        }

        if (collision.gameObject.name == "Thermometer")
        {
            float temp = GetComponent<NPC>().temp;
            display.changeInfo(temp.ToString("0.0"));
        }
    }
}
