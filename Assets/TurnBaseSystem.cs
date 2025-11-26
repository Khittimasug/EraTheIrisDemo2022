using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnBaseSystem : MonoBehaviour
{
    public Animator[] anim;
    public int whoTurn;
    // Start is called before the first frame update
    void Start()
    {
        /**anim[0] =  GameObject.FindWithTag("Shosha").GetComponent<Animator>();
        anim[1] =  GameObject.FindWithTag("Impelia").GetComponent<Animator>();**/
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            TurnBaseMainSystem1();
        }
    }

    public void EndTurn()
    {

    }

    public void NextTurn()
    {

    }

    public void TurnBaseMainSystem1()
    {
        switch (whoTurn)
        {
            case 0:
                anim[0].SetBool("Turning",true);
                whoTurn = 1;
                break;
            case 1:
                anim[1].SetBool("Turning",true);
                whoTurn = 0;
                break;
        }
    }
}
