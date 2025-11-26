using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ChangeImage : MonoBehaviour
{
    public static int ChaNumber;
    public string[] nameCha;
    public Sprite[] sr;
    //private SpriteRenderer SR;
    // Start is called before the first frame update
    void Start()
    {
        //SR = GetComponent<SpriteRenderer>();

    }
    void Awake() 
    {
       ChaNumber = 0; 
    }

    // Update is called once per frame
    void Update()
    {
        var spriteX =  GameObject.Find("CharacterImage").GetComponent<Image>();
        var nameX =  GameObject.Find("TextName").GetComponent<TMP_Text>();
        spriteX.sprite = sr[ChaNumber];
        nameX.text = nameCha[ChaNumber];
    }
}
