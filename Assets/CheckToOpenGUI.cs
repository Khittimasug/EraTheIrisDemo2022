using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckToOpenGUI : MonoBehaviour
{
    public GameObject impeliaGUI;
    public GameObject shoshaGUI;
    // Update is called once per frame
    void Update()
    {
        switch (CheckPlayer.impelia )
        {
            case true:
                impeliaGUI.SetActive(true);
                break;
            case false:
                impeliaGUI.SetActive(false);
                break;
        }
        switch (CheckPlayer.shosha )
        {
            case true:
                shoshaGUI.SetActive(true);
                break;
            case false:
                shoshaGUI.SetActive(false);
                break;
        }

    }
}
