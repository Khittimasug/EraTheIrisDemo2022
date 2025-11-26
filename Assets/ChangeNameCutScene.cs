using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ChangeNameCutScene : MonoBehaviour
{
   public static int ChaNumber;
   public string[] nameCha;
   public DialogManager dialogMan;
   public void ChangeNameCutScene1()
   {
        if(dialogMan.chaIndex == 1)
        {
            ChaNumber = 1;
        }
        else
        {
            ChaNumber = 0;
        }
   }
    void Update()
    {
        var nameX =  GameObject.Find("TextName").GetComponent<TMP_Text>();
        nameX.text = nameCha[ChaNumber];
    }
}
