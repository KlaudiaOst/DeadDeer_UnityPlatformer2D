using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{

    public float speed = 20f;
    public int damage = 1;
    public Rigidbody2D rb;

    void Start()
    {
        //rb.velocity = new Vector2(); //transform.right * speed;      
    }

    public void SetVelocity(float direction)
    {
        rb.velocity = new Vector2(speed * direction, 0);
        transform.localScale = new Vector3(direction, 1, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log(collision.name);
        Enemy enemy = collision.GetComponent<Enemy>();
        if(enemy != null)
        {
            enemy.TakeDamage(damage);
        }
        Destroy(gameObject);

        Boss boss = collision.GetComponent<Boss>();
        if (boss != null)
        {
            boss.GetComponent<BossHealth>().TakeDamage(damage);
        }
        Destroy(gameObject);
    }
}
