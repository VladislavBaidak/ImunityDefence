using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Character : MonoBehaviour
{
    public static Character Instance { get; private set; }
    public int maxHealth = 100;
    public int currentHealth;
    healthbar healthBar;

    void OnEnable()
    {
        Instance = this;
    }

    public void Inicial (healthbar HB)
    {
        healthBar = HB;
    }


    void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetmaxHealth(maxHealth);
    }

    // Update is called once per frame
    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        healthBar.SetHealth(currentHealth);
    }
}

