using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class shoshaHealth : MonoBehaviour
{
    public Slider slider;
    public static int maxHealth = 100;
    public static int currentHealth;
    // Start is called before the first frame update
    void Start()
    {
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        slider.value = currentHealth;
    }
}
