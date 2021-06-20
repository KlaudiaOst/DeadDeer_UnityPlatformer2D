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
        //rb.velocity = transform.right * speed;
    }

    public IEnumerator WaitAndShoot(float direction)
    {
        transform.localScale = new Vector3(direction, 1, 0);
        yield return new WaitForSeconds(1f);
        rb.velocity = new Vector2(speed * direction, 0);       
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

        Boss boss = collision.GetComponent<Boss>();
        if (boss != null)
        {
            boss.GetComponent<Boss>().TakeDamage(damage);
        }
        Destroy(gameObject);
    }
}
