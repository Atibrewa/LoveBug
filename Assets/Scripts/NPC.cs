using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public int symSum, score;
    public bool sweaty, fever, cough, welts, misty, heartbeat;
    public float temp;
    public int sicknessThreshold;

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
    
    /// Generates char variables 
    void generateNPC(int symSumInp)
    {
        symSum = symSumInp;
        score = sicknessThreshold-symSum;
    }

    void setTemp()
    {
        float randFloat;
        if fever {
            temp = UnityEngine.Random.Range(99.5f, 106.0f);
        } else {
            temp = UnityEngine.Random.Range(97.5f, 99.4f);
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
