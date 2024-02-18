using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCmanager : MonoBehaviour
{
    // [FirstName, LastName, Age, Gender, HomeTown] 
    // [Sweaty, Fever, Cough, Welts, Misty, Heartbeat]

    // Start is called before the first frame update
    void Start()
    {
     string[][] day1List = generateDay1();


    }

    void generateDay1()
    {
        string[][] dayList;

        string[] p0 = {"Barry", "Newton", "18", "M", "St Paul"};
        string[] p0s = {false, false, false, false, false, false};

        string[] p1 = {"Aahanaa", "Tibrewal", "20", "F", "St Paul"};
        string[] p1s= {true, true, true, false, false, true};

        string[] p2 = {"Karen", "White", "48", "F", "Edina"};
        string[] p2s = {true, false, true, false, false, false};
        string[] p3 = {"Soulai", "Vang", "21", "M", "St Paul"};
        string[] p3s = {true, false, false, false, false, true};

        string[] p4 = {"Uni", "Vang", "20", "M", "St Paul"};
        string[] p4s = {true, true, false, false, false, true};

        string[] p5 = {"Jerome", "Brown", "21", "M", "Edina"};
        string[] p5s = {true, true, true, false, false, false};

        string[] p6 = {"Kaliana", "Andria", "20", "X", "St Paul"};
        string[] p6s = {false, false, true, false, false, false};

        string[] p7 = {"Lucy", "Schroepfer", "44", "F", "St Paul"};
        string[] p7s = {true, false, true, false, false, false};

        string[] p8 = {"Gavin", "OBrien", "24", "M", "Edina"};
        string[] p8s = {true, false, false, false, false, false};

        string[] p9 = {"Lulu", "Lemonholm", "7", "F", "St Paul"};
        string[] p9s = {false, true, true, false, false, false};

        // return dayList;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
