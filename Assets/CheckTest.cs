using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckTest : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) 
    {
        if (other.gameObject.tag == "PlayerX")
        {
            Debug.Log("Hi");
        }
    }
}
