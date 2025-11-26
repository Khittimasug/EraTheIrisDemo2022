using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenEra : MonoBehaviour
{
    public GameObject era;
    public GameObject[] creditArray;
    public int openThis = 0;

    public void OpenCreditsX()
    {
        creditArray[openThis].SetActive(true);
        openThis++;
    }
    public void OpenEraX()
    {
        era.SetActive(true);
    }
}
