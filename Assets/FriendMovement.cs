using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FriendMovement : MonoBehaviour
{
    private Animator anim;
    public Animator anim2;
    float movespeed= 5f;
    public SpriteRenderer SR;
    public static int directX;
    public static int directZ;
    private Vector3 movedirection;
    private Vector3 movedirection2;
    Rigidbody rb;
    public Transform[] target;
    public Transform[] target2;
    private int CheckNum = 1;

    // Start is called before the first frame update
    void Start()
    {   
        anim = GetComponentInChildren<Animator>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G) && CheckNum == 1)
        {
            anim.SetBool("Shosha",true);
            anim2.SetBool("Impelia",true);
            CheckNum = 2;
        }
        else if (Input.GetKeyDown(KeyCode.G) && CheckNum != 1)
        {
            anim.SetBool("Shosha",false);
            anim2.SetBool("Impelia",false);
            CheckNum = 1;
        }

        movedirection2 = (target2[directZ].position - transform.position).normalized * movespeed;
        movedirection = (target[directX].position - transform.position).normalized * movespeed;
        rb.velocity = new Vector3(movedirection.x,movedirection.y,movedirection2.z);
    }
}
