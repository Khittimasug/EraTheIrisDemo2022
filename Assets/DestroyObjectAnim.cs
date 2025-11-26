using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyObjectAnim : MonoBehaviour
{
    public GameObject playerSleep;
    public GameObject player;
    public GameObject Story1;
    public GameObject faded;
    public GameObject destroyThis;
    public GameObject cutScene;
    public void DestroyThis()
    {
        cutScene.SetActive(false);
        StartCoroutine(WaitToDestroy());
    }

    IEnumerator WaitToDestroy()
   {
        playerSleep.SetActive(false);
        faded.SetActive(true);
        yield return new WaitForSeconds(2f);
        player.SetActive(true);
        Story1.SetActive(true);
        CheckPlayer.shosha = true;
        Destroy(destroyThis);
   }

}
