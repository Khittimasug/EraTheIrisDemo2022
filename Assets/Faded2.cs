using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Faded2 : MonoBehaviour
{
    public GameObject openThis;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OpenThisX3()
    {
        openThis.SetActive(true);

    }
    void CloseSelf()
    {
        Destroy(gameObject);
    }
}
