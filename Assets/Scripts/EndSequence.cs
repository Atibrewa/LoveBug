using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndSequence : MonoBehaviour
{
    public int score;
    public GameObject badEnding;
    public GameObject goodEnding;
    public GameObject neutralEnding;

    void Start()
    {
        badEnding.SetActive(false);
        goodEnding.SetActive(false);
        neutralEnding.SetActive(false);
    }

    public void chooseEnding(int score)
    {
        GameObject.Find("InterfaceCanvas").SetActive(false);
        GameObject.Find("DialogueCanvas").SetActive(false);
        if (score < -10) {
            badEnding.SetActive(true);
        }
        else if (score > 10) {
            goodEnding.SetActive(true);
        }
        else {
            neutralEnding.SetActive(true);
        }
    }
}
