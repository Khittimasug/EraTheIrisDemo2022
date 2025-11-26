using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCast1 : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float distance;
    public LayerMask layer;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Physics.Raycast(transform.position,Vector2.right,distance,layer))
        {
            Debug.DrawRay(transform.position, Vector2.right * distance,Color.green);
            FriendMovement.directX = 1;
        }
        else
        {
            Debug.DrawRay(transform.position, Vector2.right * distance,Color.red);
            FriendMovement.directX = 2;
        }
    }
}
