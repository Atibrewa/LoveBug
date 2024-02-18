using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;

public class NPCManager : MonoBehaviour
{
    // [FirstName, LastName, Age, Gender, HomeTown] 
    // [Sweaty, Fever, Cough, Welts, Misty, Heartbeat]

    // Start is called before the first frame update
    List<string[]> dayList;
    List<bool[]> symList;
    int currClient;
    GameObject npc;
    EndSeq ending = new EndSeq;
    bool runOnce = false;

    void Start()
    {
        currClient = 0;
        npc = GameObject.Find("Client");
        generateDay1();
    }

    public void rotateNPC(){
        npc.GetComponent<NPC>().nextNPC(dayList[currClient], symList[currClient]);
        if (currClient < dayList.Count - 1)
        {
            currClient++;
        }
        else
        {
            endSeq.initiate();
        }
    }
    

    void generateDay1()
    {
        string[] p0 = new string[5] {"Barry", "Newton", "18", "M", "St Paul"};
        bool[] p0s = new bool[7] {false, false, false, false, false, false, false};

        string[] p1 = new string[5] {"Aahanaa", "Tibrewal", "20", "F", "St Paul"};
        bool[] p1s= new bool[7] {true, true, true, false, false, true, false};

        string[] p2 = new string[5] {"Karen", "White", "48", "F", "Edina"};
        bool[] p2s = new bool[7] {true, false, true, false, false, false, true};

        string[] p3 = new string[5] {"Soulai", "Vang", "21", "M", "St Paul"};
        bool[] p3s = new bool[7] {true, false, false, false, false, true, false};

        string[] p4 = new string[5] {"Uni", "Vang", "20", "M", "St Paul"};
        bool[] p4s = new bool[7] {true, true, false, false, false, true, false};

        string[] p5 = new string[5] {"Jerome", "Brown", "21", "M", "Edina"};
        bool[] p5s = new bool[7] {true, true, true, false, false, false, true};

        string[] p6 = new string[5] {"Kaliana", "Andria", "20", "X", "St Paul"};
        bool[] p6s = new bool[7] {false, false, true, false, false, false, false};

        string[] p7 = new string[5] {"Lucy", "Schroepfer", "44", "F", "St Paul"};
        bool[] p7s = new bool[7] {true, false, true, false, false, false, false};

        string[] p8 = new string[5] {"Gavin", "OBrien", "24", "M", "Edina"};
        bool[] p8s = new bool[7] {true, false, false, false, false, false, true};

        string[] p9 = new string[5] {"Lulu", "Lemonholm", "7", "F", "St Paul"};
        bool[] p9s = new bool[7] {false, true, true, false, false, false, false};

        dayList = new List<string[]>(){p0, p1, p2, p3, p4, p5, p6, p7, p8, p9};
        symList = new List<bool[]>(){p0s, p1s, p2s, p3s, p4s, p5s, p6s, p7s, p8s, p9s};
    }

    // Update is called once per frame
    void Update()
    {
        while(!runOnce) 
        {
            rotateNPC();
            runOnce = true;
        }
    }
}
