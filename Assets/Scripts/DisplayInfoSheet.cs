using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DisplayInfoSheet : MonoBehaviour
{
    public TextMeshProUGUI information;
    public GameObject sheetSpriteEnlarged;
    public GameObject button;
    // Start is called before the first frame update
    void Start()
    {
        sheetSpriteEnlarged.SetActive(false);
        button.SetActive(false);
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
                sheetSpriteEnlarged.SetActive(true);
                button.SetActive(true);
            }
            else if (targetObject.name == "InfoSheet_Button")
            {
                sheetSpriteEnlarged.SetActive(false);
                button.SetActive(false);
            }
        }

    }
}
