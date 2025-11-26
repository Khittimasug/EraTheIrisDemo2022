using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CatFishStats : MonoBehaviour
{
    private int damage = 20;
    public Slider slider;
    public static int currentHealth;
    public static int maxHealth = 200;
    private Animator anim;
    private Animator anim2;
    public GameObject Battle;
    public GameObject checkCanvas;
    public GameObject DestroyThis;
    // Start is called before the first frame update
    void Start()
    {
        anim2 =  GameObject.FindWithTag("Shosha").GetComponent<Animator>();
        anim = GetComponent<Animator>();
        slider.maxValue = maxHealth;
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = currentHealth;
        if (currentHealth <= 0)
        {
            Destroy(DestroyThis);
            Destroy(gameObject);
            Battle.SetActive(false);
            checkCanvas.SetActive(true);
        }
    }

    public void DamageToPlayer()
    {
        shoshaHealth.currentHealth -= damage;
        anim.SetBool("Turning",false);
        anim2.SetBool("Turning",true);

    }
    IEnumerator X5()
   {
        yield return new WaitForSeconds(2f);
        checkCanvas.SetActive(true);
   }
}
