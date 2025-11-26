using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShoshaSkill : MonoBehaviour
{
    private Animator anim;
    public GameObject chooseMoveShosha;
    public GameObject chooseMoveImpelia;
    public TurnBaseSystem turnBaseSystem;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        anim = GetComponent<Animator>();
    }

    public void ShoshaFirstMove()
    {
        CatFishStats.currentHealth -= 50;
        
    }
    public void ImpeliaFirstMove()
    {
        CatFishStats.currentHealth -= 7;
    }

    public void ShoshaTurn1()
    {
        chooseMoveShosha.SetActive(true);
    }
    public void ImpeliaTurn1()
    {
        chooseMoveImpelia.SetActive(true);
    }
    public void DisableAttacking()
    {

        anim.SetBool("Turning",false);
        anim.SetBool("Attacking",false);
        anim.SetInteger("State",0);
        turnBaseSystem.anim[turnBaseSystem.whoTurn].SetBool("Turning",true);
    }

    public void EnabledAttack()
    {
        anim.SetBool("Attacking",true);
    }

    public void SetIntSkill(int numberSkill)
    {
        anim.SetInteger("State",numberSkill);
    }
}
