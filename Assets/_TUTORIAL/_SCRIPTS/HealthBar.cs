using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider healthBar;
    [SerializeField]
    PlayerController playerHealth; 
    [SerializeField]
    float health;
    // Start is called before the first frame update
    void Start()
    {
        healthBar = GetComponent<Slider>();
        healthBar.maxValue = playerHealth._maxHealth;
        healthBar.value = playerHealth.health;
        health = playerHealth.health;
    }

    // Update is called once per frame
    void Update()
    {
        healthBar.value = playerHealth.health;
        health  = playerHealth.health;
    }
}
