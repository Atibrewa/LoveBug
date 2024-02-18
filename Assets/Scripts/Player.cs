using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int score = 0;
    public int day = 1;
    GameObject manager;
    GameObject client;

    void Start()
    {
        manager = GameObject.Find("NPCManager");
        client = GameObject.Find("Client");
    }


    public void accept()
    {
        manager.GetComponent<NPCManager>().rotateNPC();
        score += client.GetComponent<NPC>().score;
    }

    public void deny()
    {
        manager.GetComponent<NPCManager>().rotateNPC();
        score -= client.GetComponent<NPC>().score;
    }

}
