using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToolUse : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Stethoscope")
        {
            Debug.Log(GetComponent<NPC>().heartbeat);
        }

        if (collision.gameObject.name == "Thermometer")
        {
            float temp = GetComponent<NPC>().temp;
        }
    }
}
