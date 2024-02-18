using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolUse : MonoBehaviour
{
    public DisplayDiagnostics display;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Stethoscope")
        {
            display.changeInfo(GetComponent<NPC>().heartbeat.ToString());
        }

        if (collision.gameObject.name == "Thermometer")
        {
            float temp = GetComponent<NPC>().temp;
            display.changeInfo(temp.ToString());
        }
    }
}
