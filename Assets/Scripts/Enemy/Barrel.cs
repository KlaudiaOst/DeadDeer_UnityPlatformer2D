using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrel : MonoBehaviour
{
    Animator animator;
    bool isGrounded;
    Rigidbody2D rb;
    public float speed;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        isGrounded = false;
        animator = GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //if (collision.gameObject.tag == "Player")
        //{
        //    Destroy(animator.gameObject, 1f);
        //}

        isGrounded = true;
        animator.SetBool("grounded", true);        
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.layer == 8)
        {
            isGrounded = false;
            animator.SetBool("grounded", false);
        }
    }

    private void OnBecameInvisible()
    {
        Destroy(gameObject);
    }
}
