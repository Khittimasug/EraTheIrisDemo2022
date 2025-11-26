using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Escape : MonoBehaviour
{

    void Update()
    {
        if (Input.GetKey("escape"))
        {
            StartCoroutine(LoadSceneAsync(0)); 
        }
    }
    IEnumerator LoadSceneAsync(int sceneId)
    {
        AsyncOperation operation = SceneManager.LoadSceneAsync(sceneId);
        yield return null;
    }
}
