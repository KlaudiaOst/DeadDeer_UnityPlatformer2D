using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossHealth : MonoBehaviour
{
    public int maxHealth = 50;
    public float knockbackForce = 300;
    public int damage;
    int currentHealth;

    public Transform player;

    public GameObject deathEffect;

    public bool isInvulnerable = false;

    //public HealthBar healthBar;

    void Start()
    {
        currentHealth = maxHealth;
        //healthBar.SetMaxHealth(health);
    }
    public void TakeDamage(int damage)
    {
        if (isInvulnerable)
            return;

        currentHealth -= damage;

        //healthBar.SetHealth(health);

        if (currentHealth <= 20)
        {
            GetComponent<Animator>().SetBool("IsEnraged", true);
        }

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        //Instantiate(deathEffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

   
}
