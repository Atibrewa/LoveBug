using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{

    public bool sweaty, fever, cough, welts, misty, heartbeat;

    // Start is called before the first frame update
    void Start()
    {
        // Kaliana will write the way it is declared/ how the npcs get assigned symptoms based on the preset scores etc

        // for testing purposes to setup rest of game
        sweaty = true;
        fever = true;
        cough = true;
        welts = true;
        misty = true;
        heartbeat = true;
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
