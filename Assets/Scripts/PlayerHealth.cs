using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    float maxHealth = 100, minHealth = 0;
    float currentHealth;

    bool isDead = false;
    private void Start()
    {
        currentHealth = maxHealth;
    }
    private void Update()
    {
        if(currentHealth <= minHealth)
        {
            isDead = true;
            currentHealth = minHealth;
        }
    }
    public void AddHealth(float hP)
    {
        currentHealth += hP;
    }
    public void ReduceHealth(float hP)
    {
        currentHealth -= hP;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Life"))//when he collects a Life
        {
            AddHealth(20);
        }
    }
}
