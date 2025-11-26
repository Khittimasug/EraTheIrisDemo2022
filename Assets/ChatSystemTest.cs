using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChatSystemTest : MonoBehaviour
{
    public int npcNumber;
    public GameObject[] dialogMan;
    public GameObject pressF;
    public GameObject[] chatCanvas;
    public static bool enter = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (enter && Input.GetKeyDown(KeyCode.F))
        {
            Debug.Log("Chat");
            chatCanvas[npcNumber].SetActive(true);
            dialogMan[npcNumber].SetActive(true);
        }
    }
    private void OnTriggerEnter(Collider other) 
    {
        switch (other.tag)
        {
            case "NPC0":
                Debug.Log("0");
                enter = true;
                pressF.SetActive(true);
                npcNumber = 0;
                break;
            case "NPC1":
                Debug.Log("1");
                enter = true;
                pressF.SetActive(true);
                npcNumber = 1;
                break;
        }
    }
    private void OnTriggerExit(Collider other) {
        switch (other.tag)
        {
            case "NPC0":
                enter = false;
                pressF.SetActive(false);
                break;
            case "NPC1":
                enter = false;
                pressF.SetActive(false);
                break;
        }
    }
}
