using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstMeetNPC : MonoBehaviour
{
    public HowToplay howToplay;
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider other) 
    {
        if (other.tag == "PlayerX")
        {
            howToplay.howToNumber = 2;
            howToplay.howTo[howToplay.howToNumber].SetActive(true);
            Destroy(gameObject);
            
        }
    }
}
