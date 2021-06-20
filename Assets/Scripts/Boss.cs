using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Boss : MonoBehaviour
{
    public Transform player;
    public int damage;
    public float knockbackForce = 400;
    public int maxHealth = 100;
    int currentHealth;

    public bool isFlipped = false;

    public HealthBar healthBar;

    public string sceneNameToLoad;

    private void Start()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    public void LookAtPlayer()
    {
        Vector3 flipped = transform.localScale;
        flipped.z *= -1f;
        
        if (transform.position.x > player.position.x && isFlipped)
        {
            transform.localScale = flipped;
            transform.Rotate(0f, 180f, 0f);
            isFlipped = false;
        }
        else if (transform.position.x < player.position.x && !isFlipped)
        {
            transform.localScale = flipped;
            transform.Rotate(0f, 180f, 0f);
            isFlipped = true;
        }
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        healthBar.SetHealth(currentHealth);

        if (currentHealth <= 0)
        {
            //Destroy(gameObject);

            Die();

        }
    }
    void Die()
    {
        Debug.Log("Boss died");
        //animator.SetBool("dead", true);

        GetComponent<Collider2D>().enabled = false;
        this.enabled = false;
        Destroy(gameObject);
        SceneManager.LoadScene(sceneNameToLoad);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Vector2 vector = new Vector2(0, knockbackForce);
            collision.gameObject.GetComponent<Rigidbody2D>().AddForce(vector);

            collision.gameObject.GetComponent<PlayerHealth>().Damage(damage);

            //animator.SetTrigger("attack");
        }
    }

    //IEnumerator Win()
    //{
    //    if (currentHealth <= 0)
    //    {
    //        yield return new WaitForSeconds(5f);
    //        SceneManager.LoadScene(sceneNameToLoad);
    //    }
        
    //}
}
