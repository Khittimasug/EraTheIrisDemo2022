using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class OpenMenu1 : MonoBehaviour
{
    public GameObject newGame;
    public GameObject exit;

    public void OpenGUIMenu()
    {
        newGame.SetActive(true);
        exit.SetActive(true);
    }

    public void NextScene()
    {
        StartCoroutine(LoadSceneAsync(1));
    }
    IEnumerator LoadSceneAsync(int sceneId)
    {
        yield return new WaitForSeconds(2f);
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneId);
        yield return null;
    }

}
