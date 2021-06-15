using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialAttackBullet : MonoBehaviour
{
    public float speed = 10f;
    public int damage = 1;
    public Rigidbody2D rb;

    void Start()
    {
        //odniesienie do huda, czy mam wystarczającą liczbę dusz
        //tutaj chcę odczekać chwilę
        rb.velocity = transform.right * speed;
    }

    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.name);
        Enemy enemy = collision.GetComponent<Enemy>();
        if (enemy != null)
        {
            enemy.TakeDamage(damage);
        }
        Destroy(gameObject);
    }
}
