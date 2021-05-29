using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public int damage;
    public float knockbackForce = 300;
    public int maxHealth= 3;
    int currentHealth;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Player"))
        {
            Vector2 vector = new Vector2(0, knockbackForce);
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(vector);

            collision.gameObject.GetComponent<PlayerHealth>().Damage(damage);
        }
    }

    private void Start()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth <= 0)
        {
            Destroy(gameObject);
            Die();
        }
    }

    void Die()
    {
        Debug.Log("Enemy died");
    }
}

