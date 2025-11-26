using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobDetect1 : MonoBehaviour
{
    public GameObject battle1;
    public HowToplay howToplay;
    public Animator anim2;
    public Animator playerAnim;
    public Animator emergency;
    public PlayerMovement player;

    void Start()
    {
        
    }
    void Update()
    {
       
    }
    public void OnTriggerEnter(Collider other) 
    {
        if (other.tag == "PlayerX")
        {
            StartCoroutine(X1());
            
        }
    }
    IEnumerator X1()
   {
            emergency.SetTrigger("Meet");
            playerAnim.SetInteger("State",0);
            player.enabled = false;
            yield return new WaitForSeconds(1f);
            battle1.SetActive(true);
            yield return new WaitForSeconds(2f);
            howToplay.howToNumber = 1;
            howToplay.howTo[howToplay.howToNumber].SetActive(true);
            anim2.SetBool("Turning",true);
   }
}
