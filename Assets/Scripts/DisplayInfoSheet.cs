using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DisplayInfoSheet : MonoBehaviour
{
    public TextMeshProUGUI information;
    public GameObject sheetSpriteEnlarged;
    public GameObject button;
    GameObject currClient;
    private string[] infoToAdd;
    // Start is called before the first frame update
    void Start()
    {
        information.gameObject.SetActive(false);
        sheetSpriteEnlarged.SetActive(false);
        button.SetActive(false);
        currClient = GameObject.Find("Client");
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if (Input.GetMouseButtonDown(0))
        {
            Collider2D targetObject = Physics2D.OverlapPoint(mousePosition);

            if (targetObject.name == "InfoSheet")
            {
                information.gameObject.SetActive(true);
                sheetSpriteEnlarged.SetActive(true);
                button.SetActive(true);
                GetInfo();
            }
            else if (targetObject.name == "InfoSheet_Button")
            {
                information.gameObject.SetActive(false);
                sheetSpriteEnlarged.SetActive(false);
                button.SetActive(false);
            }
        }

    }

    void GetInfo()
    {
        infoToAdd = currClient.GetComponent<NPC>().infoSheet;
        foreach (string info in infoToAdd)
        {
            Debug.Log(info);
            information.text += " " + info;
        }
    }
}
