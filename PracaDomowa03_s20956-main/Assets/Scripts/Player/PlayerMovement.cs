using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public float speed = 10;
    public float jumpForce = 400;

    private Rigidbody2D rb;
    private bool isGrounded;
    private Animator animator;


    // Start is called before the first frame update
    void Start() {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        isGrounded = true;
        
    }

    // Update is called once per frame
    void Update() {
        float xDisplacement = Input.GetAxis("Horizontal") * speed;
        rb.velocity = new Vector2(xDisplacement, rb.velocity.y);
        animator.SetFloat("speed", rb.velocity.x);

        //flip
        Vector3 characterScale = transform.localScale;
        if (Input.GetAxis("Horizontal") < 0)
        {
            characterScale.x = -1;
        }
        if (Input.GetAxis("Horizontal") > 0)
        {
            characterScale.x = 1;
        }
        transform.localScale = characterScale;


        if (Input.GetKeyDown(KeyCode.Space) && isGrounded) {
            rb.AddForce(new Vector2(0, jumpForce));
            isGrounded = false;
            animator.SetTrigger("jump");
        }

        if (Input.GetKeyDown(KeyCode.X))  {
            animator.SetTrigger("death");
        }
    }

    void OnCollisionEnter2D(Collision2D col) {
        isGrounded = true;
    }
}
