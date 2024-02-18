using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StethoscopeUse : MonoBehaviour
{
    public NPC client;
    // Update is called once per frame
    void Update()
    {
        //Debug.Log(client.getHeartbeat());
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Client")
        {
            Debug.Log(client.getHeartbeat());
        }

        if (collision.gameObject.tag == "NPC")
        {
            Debug.Log(client.getHeartbeat());
        }
    }
}
