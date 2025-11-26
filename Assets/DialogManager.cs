using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class DialogManager : MonoBehaviour
{
   public GameObject loadScene;
   public GameObject cutScene;
   private Animator anim;
   public AudioClip[] audioX;
   public AudioSource audioMain;
   public TextMeshProUGUI textDisplay;
   public string[] sentences;
   public int chaIndex;
   public int decreaseNum = 1;
   public GameObject dialogDisplay;

   public static int a = 1;
   public float typingSpeed;
   public GameObject continueButton;
   public bool issentence;
   //public movement mv;
   //public npcdetect npcDectect;

   void Start()
   {
     continueButton.SetActive(false);
     issentence = false;
     anim = GetComponentInChildren<Animator>();
   }
   void Awake() 
   {
     StartCoroutine(Type());
   }

    void Update() 
    {
        if(textDisplay.text == sentences[chaIndex] )
        {
            continueButton.SetActive(true);
            issentence = true;
        }
    }

   IEnumerator Type()
   {
     foreach(char letter in sentences[chaIndex].ToCharArray())
     {
        textDisplay.text += letter;
        yield return new WaitForSeconds(typingSpeed);
     }
   }

   public void NextSentence()
   {
    a += 1;
    continueButton.SetActive(false);
    issentence = false;

    if(chaIndex < sentences.Length - decreaseNum)
    {
        chaIndex += 1;
        typingSpeed = 0.1f;
        textDisplay.text = "";
        switch (ChangeImage.ChaNumber)
        {
            case 0:
                ChangeImage.ChaNumber = 1;
                break;
            case 1:
                ChangeImage.ChaNumber = 0;
                break;
        }
        StartCoroutine(Type()); 
    }
    else
    {
        dialogDisplay.SetActive(false);
    }
   }
    public void Skip()
    {
        //textDisplay.text = sentences[index];
        typingSpeed = 0f;
        //ChangeImage.ChaNumber = 1;
    }
    public void ChangeAudio()
    {
        switch (chaIndex)
        {
            case 1:
                audioMain.clip = audioX[1];
                audioMain.enabled = false;
                audioMain.enabled = true;
                break;
            case 2:
                audioMain.clip = audioX[2];
                audioMain.enabled = false;
                audioMain.enabled = true;
                break;
            case 3:
                audioMain.clip = audioX[3];
                audioMain.enabled = false;
                audioMain.enabled = true;
                break;
        }
    }
    public void NextSentenceCutScene()
   {
    a += 1;
    continueButton.SetActive(false);
    issentence = false;

    if(chaIndex < sentences.Length - decreaseNum)
    {
        chaIndex += 1;
        typingSpeed = 0.1f;
        textDisplay.text = "";
        switch (ChangeImage.ChaNumber)
        {
            case 0:
                ChangeImage.ChaNumber = 1;
                break;
            case 1:
                ChangeImage.ChaNumber = 0;
                break;
        }
        StartCoroutine(Type()); 
    }
    else
    {
        audioX[3] = null;
        dialogDisplay.SetActive(false);
        loadScene.SetActive(true);
        cutScene.SetActive(false);
        StartCoroutine(LoadSceneAsync(2));
    }
   }
   public void SetInt()
   {
                switch (chaIndex)
        {
            case 0:
                anim.SetInteger("CutScene",1);
                break;
            case 1:
                anim.SetInteger("CutScene",2);
                break;
        }
   }
    IEnumerator LoadSceneAsync(int sceneId)
    {
        yield return new WaitForSeconds(5f);
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneId);
        yield return null;
        /**while(!operation.isDone)
        {
            float progressValue = Mathf.Clamp01(operation.progress / speed);
            LoadingBarFill.fillAmount = progressValue;

            yield return null;
        }**/
    }

}
