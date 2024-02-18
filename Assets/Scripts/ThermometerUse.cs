using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThermometerUse : MonoBehaviour
{
    public GameObject client;
    bool fever;
    float temp;

    // Start is called before the first frame update
    void Start()
    {   
        
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void CheckTemp()
    {
        float randFloat;
        fever = client.GetComponent<NPC>().fever;
        if fever {
            randFloat = UnityEngine.Random.Range(99.5f, 106.0f);
        } else {
            randFloat = UnityEngine.Random.Range(97.5f, 99.4f);
        }

    }
}
