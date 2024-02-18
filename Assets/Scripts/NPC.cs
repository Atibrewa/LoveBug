using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public string[] infoSheet;
    public string hometown;
    public bool sweaty, fever, cough, welts, misty, heartbeat, bannedCity;
    public float temp;
    public int symSum, score;
    int sicknessThreshold = 2;
    
    // Start is called before the first frame update
    void Start()
    {
        // Kaliana will write the way it is declared/ how the npcs get assigned symptoms based on the preset scores etc
        // fName = "Uni";
        // lName = "Vang";
        // hometown = "St Paul";

        // // for testing purposes to setup rest of game
        // sweaty = true;
        // fever = true;
        // cough = true;
        // welts = true;
        // misty = true;
        // heartbeat = true;

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
    /// Generates char variables 
    void nextNPC(string[] newDudette, bool[] symptoms)
    {
        // String: [FirstName, LastName, Age, Gender, HomeTown] 
        // Bool: [Sweaty, Fever, Cough, Welts, Misty, Heartbeat, City]

        infoSheet = newDudette;
        hometown = newDudette[4];

        sweaty = symptoms[0];
        fever = symptoms[1];
        cough = symptoms[2];
        welts = symptoms[3];
        misty = symptoms[4];
        heartbeat = symptoms[5];
        bannedCity = symptoms[6];

        setTemp();
        setSicknessScores();
        score = sicknessThreshold - symSum;

    }

    void setTemp()
    {
        if (fever) {
            temp = UnityEngine.Random.Range(99.5f, 106.0f);
        } else {
            temp = UnityEngine.Random.Range(97.5f, 99.4f);
        }
    }

    void setSicknessScores()
    {
        symSum = 0;
        if (sweaty) {
            symSum ++;
        }
        if (fever) {
            symSum += 2;
        }
        if (cough) {
            symSum ++;
        }
        if (welts) {
            symSum += 2;
        }
        if (misty) {
            symSum += 2;
        }
        if (heartbeat) {
            symSum += 2;
        }

        if (bannedCity) {
            symSum = 5;
        }

    }

}
