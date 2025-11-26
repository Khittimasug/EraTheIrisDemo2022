using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{ 
    public Animator anim2;
    public Animator anim;
    private SpriteRenderer sr;
    public SpriteRenderer sr2;
    private Rigidbody2D rb;
    public Vector3 movement;
    public float moveSpeed = 5f;
    public int faceDirection = 0;
    public bool siding = false;
    public static bool moving = false;
    // Start is called before the first frame update
    void Start()
    {
         rb = GetComponent<Rigidbody2D>();
         sr = GetComponentInChildren<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        anim2.SetBool("Siding",false);
        anim.SetBool("Siding",false);
        
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.z = Input.GetAxisRaw("Vertical");
        if (movement.x != 0f || movement.z != 0f)
        {
            moving = true;
        }
        else
        {
            moving = false;
        }
        //rb.MovePosition(transform.position + movement * moveSpeed * Time.fixedDeltaTime);
        transform.Translate(0f,0f,Time.deltaTime*moveSpeed*movement.z);
        transform.Translate(moveSpeed*movement.x*Time.deltaTime,0f,0f);

        switch (movement.x)
        {
            case -1f:
                anim2.SetBool("Siding",true);
                anim.SetBool("Siding",true);
                anim2.SetInteger("State", 1);
                anim.SetInteger("State", 1);
                sr.flipX = true;
                sr2.flipX = true;
                break;
            case 0f:
                anim2.SetInteger("State", 0);
                anim.SetInteger("State", 0);
                break;
            case 1f:
                anim2.SetBool("Siding",true);
                anim.SetBool("Siding",true);
                anim2.SetInteger("State", 1);
                anim.SetInteger("State", 1);
                sr.flipX = false;
                sr2.flipX = false;
                //anim.SetTrigger("WalkSide");
                break;
        }
        switch (movement.z)
        {
            case 1f:
                anim2.SetInteger("State", 3);
                anim.SetInteger("State", 3);
                break;
            case -1f:
                anim2.SetInteger("State", 2);
                anim.SetInteger("State", 2);
                break;
        }
    }
}
