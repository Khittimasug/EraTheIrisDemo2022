using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HowToplay : MonoBehaviour
{
    public int howToNumber = 0;
    public GameObject[] howTo;

    public void OpenHowTo()
    {
        howTo[howToNumber].SetActive(true);
    }
}
