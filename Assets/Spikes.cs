using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Spikes : MonoBehaviour
{
    public int damage;
    public float knockbackForce = 300;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Vector2 vector = new Vector2(0, knockbackForce);
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(vector);

            collision.gameObject.GetComponent<PlayerHealth>().Damage(damage);


        }
    }
}
