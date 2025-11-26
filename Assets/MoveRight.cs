using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRight : MonoBehaviour
{
    public GameObject FadedCut;
    public Animator anim;

    void Update()
    {
        
        transform.Translate(3*1*Time.deltaTime,0f,0f);
        anim.SetInteger("State",1);
        FadedCut.SetActive(true);
    }
}
