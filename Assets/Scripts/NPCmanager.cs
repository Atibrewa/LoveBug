using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCmanager : MonoBehaviour
{
    // [FirstName, LastName, Age, Gender, HomeTown] 
    // [Sweaty, Fever, Cough, Welts, Misty, Heartbeat]

    // Start is called before the first frame update
    string[][] dayList;
    bool[][] symList;
    int currClient;
    GameObject npc;

    void Start()
    {
        currClient = 0;
        npc = GameObject.Find("Client");
        generateDay1();
        rotateNPC();
    }

    public void rotateNPC(){
        npc.GetComponent<NPC>().nextNPC(dayList[currClient], symList[currClient]);
        if (currClient < dayList.Length)
        {
            currClient++;
        }
        else
        {
            currClient = 0;
        }
    }
    

    void generateDay1()
    {
        string[] p0 = {"Barry", "Newton", "18", "M", "St Paul"};
        bool[] p0s = {false, false, false, false, false, false};
        dayList[0] = p0;
        symList[0] = p0s;

        string[] p1 = {"Aahanaa", "Tibrewal", "20", "F", "St Paul"};
        bool[] p1s= {true, true, true, false, false, true};
        dayList[1] = p1;
        symList[1] = p1s;

        string[] p2 = {"Karen", "White", "48", "F", "Edina"};
        bool[] p2s = {true, false, true, false, false, false};
        dayList[2] = p2;
        symList[2] = p2s;

        string[] p3 = {"Soulai", "Vang", "21", "M", "St Paul"};
        bool[] p3s = {true, false, false, false, false, true};
        dayList[3] = p3;
        symList[3] = p3s;

        string[] p4 = {"Uni", "Vang", "20", "M", "St Paul"};
        bool[] p4s = {true, true, false, false, false, true};
        dayList[4] = p4;
        symList[4] = p4s;

        string[] p5 = {"Jerome", "Brown", "21", "M", "Edina"};
        bool[] p5s = {true, true, true, false, false, false};
        dayList[5] = p5;
        symList[5] = p5s;

        string[] p6 = {"Kaliana", "Andria", "20", "X", "St Paul"};
        bool[] p6s = {false, false, true, false, false, false};
        dayList[6] = p6;
        symList[6] = p6s;

        string[] p7 = {"Lucy", "Schroepfer", "44", "F", "St Paul"};
        bool[] p7s = {true, false, true, false, false, false};
        dayList[7] = p7;
        symList[7] = p7s;

        string[] p8 = {"Gavin", "OBrien", "24", "M", "Edina"};
        bool[] p8s = {true, false, false, false, false, false};
        dayList[8] = p8;
        symList[8] = p8s;

        string[] p9 = {"Lulu", "Lemonholm", "7", "F", "St Paul"};
        bool[] p9s = {false, true, true, false, false, false};
        dayList[9] = p9;
        symList[9] = p9s;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
