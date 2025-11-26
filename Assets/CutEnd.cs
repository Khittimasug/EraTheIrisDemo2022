using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CutEnd : MonoBehaviour
{
    public DialogManager dialogManager;
    public GameObject Iris;
    public GameObject canvas;
    public MoveRight moveRight;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (dialogManager.chaIndex == 27)
        {
            StartCoroutine(XEE());
        }
    }
    IEnumerator XEE()
   {
        Iris.SetActive(true);
        yield return new WaitForSeconds(2f);
        moveRight.enabled = true;
        //canvas.SetActive(true);
   }
}
