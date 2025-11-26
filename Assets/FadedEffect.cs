using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FadedEffect : MonoBehaviour
{
    public GameObject faded;

    public void DisableFade()
    {
        faded.SetActive(false);
    }

    public void DisableSelf()
    {
        gameObject.SetActive(false);
    }
}
