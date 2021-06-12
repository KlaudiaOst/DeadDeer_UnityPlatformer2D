using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public Animator animator;
    public int health;
    public const int MAX_HEALTH = 3;

    


    void Start()
    {
        
        health = 5;


        if(PlayerPrefs.HasKey("Health"))
        {
            health = PlayerPrefs.GetInt("Health");
        }
        if (PlayerPrefs.HasKey("Coins"))
        {
            health = PlayerPrefs.GetInt("Coins");
        }

        UpdateHUD();
    }

    public void Damage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            health = 0;
            StartCoroutine(Die());
            
        }

        UpdateHUD();
    }

    public void Heal (int i)
    {
        health += i;
        if(health > MAX_HEALTH)
        {
            health = MAX_HEALTH;
        }
    }
    
    

    public void UpdateHUD()
    {
        //GameObject.Find("Canvas-HUD").GetComponent<HUDManager>().SetPlayersHealth(health);

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Puddle"))
        {
            animator.SetTrigger("death");
            Debug.Log(collision);
            
            //Rigidbody2D rb = animator.gameObject.GetComponent<Rigidbody2D>();
            //rb.velocity = new Vector2(0, rb.velocity.y)
            StartCoroutine(Die());
            
        }

    }

    public IEnumerator Die()
    {
        animator.SetTrigger("death");
        animator.gameObject.GetComponent<PlayerMovement>().enabled = false;
        yield return new WaitForSeconds(3);        
        PlayerPrefs.SetInt("Health", 3);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
    }
    
}