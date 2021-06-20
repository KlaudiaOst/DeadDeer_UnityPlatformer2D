using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public Animator animator;
    public int health;
    public const int MAX_HEALTH = 5;

    public int numOfHearts;
    public Image[] hearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;

    //public HealthBar healthBar;

    void Start()
    {
        
        health = 5;


        if(PlayerPrefs.HasKey("Health"))
        {
            health = PlayerPrefs.GetInt("Health");
        }

       // healthBar.SetMaxHealth(MAX_HEALTH);


        UpdateHUD();
    }

    void Update()
    {
        if (health > numOfHearts)
        {
            health = numOfHearts;
        }



        for (int i = 0; i < hearts.Length; i++)
        {
            if (i < health)
            {
                hearts[i].sprite = fullHeart;
            }
            else
            {
                hearts[i].sprite = emptyHeart;
            }


            if (i < numOfHearts)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }
    }

    public void Damage(int damage)
    {
        health -= damage;

        if (health <= 0)
        {
            health = 0;
            StartCoroutine(Die());
            
        }
       // healthBar.SetHealth(health);

        UpdateHUD();
    }

    public void Heal (int i)
    {
        health += i;
        if(health > MAX_HEALTH)
        {
            health = MAX_HEALTH;
        }

        UpdateHUD();
    }
    
    

    public void UpdateHUD()
    {
        GameObject.Find("Canvas-HUD").GetComponent<HUDManager>().SetPlayersHealth(health);

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
        PlayerPrefs.SetInt("Health", 5);
        PlayerPrefs.SetInt("Coins", 0);
        PlayerPrefs.SetInt("Souls", 0);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        
    }
    
}