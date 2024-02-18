using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public int symSum, score;
    public bool sweaty, fever, cough, welts, misty, heartbeat;
    public float temp;
    public int sicknessThreshold;
    public string fName, lName, hometown;

    // Start is called before the first frame update
    void Start()
    {
        // Kaliana will write the way it is declared/ how the npcs get assigned symptoms based on the preset scores etc
        fName = "Uni";
        lName = "Vang";
        hometown = "St Paul";

        // for testing purposes to setup rest of game
        sweaty = true;
        fever = true;
        cough = true;
        welts = true;
        misty = true;
        heartbeat = true;

        bool[] minorSymptoms = {sweaty, cough};
        bool[] majorSymptoms = {fever, heartbeat, welts, misty};
    }
    
    /// Generates char variables 
    void generateNPC(string[] newDudette, bool[] symptoms, string first, string last, int symSumInp)
    {

        // [FirstName, LastName, Age, Gender, HomeTown] 
        // [Sweaty, Fever, Cough, Welts, Misty, Heartbeat]

        symSum = symSumInp;
        score = sicknessThreshold-symSum;
        fName = first;
        lName = last;

    }


    // return int[] generateSymptomes(int symSumInp){
    //     int[] symList = {0};
    //     if (symSumInp == 0)
    //     {
    //         return symList;
    //     } else if (symSumInp == 1) {
    //         symList[0] = 1;
    //     }
    // }

    void setTemp()
    {
        if (fever) {
            temp = UnityEngine.Random.Range(99.5f, 106.0f);
        } else {
            temp = UnityEngine.Random.Range(97.5f, 99.4f);
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    public bool getHeartbeat()
    {
        return heartbeat;
    }
}
