using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {
    public float speed = 10;
    public float jumpForce = 800;

    private Rigidbody2D rb;
    private bool isGrounded;
    private Animator animator;
    private float prev;
    private float current;


    // Start is called before the first frame update
    void Start() {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        isGrounded = true;
       // prev = transform.position.y;
       // current = transform.position.y;
    }

    // Update is called once per frame
    void Update() {
        float xDisplacement = Input.GetAxis("Horizontal") * speed;
        rb.velocity = new Vector2(xDisplacement, rb.velocity.y);
        animator.SetFloat("speed", rb.velocity.x);

        

        //current = transform.position.y;

        //if (current < prev)
        //{
        //    animator.SetTrigger("fall");
        //}

        prev = current;

        /*if (rb.velocity.y < 0 && !isGrounded) 
        {
            animator.SetTrigger("fall");
        }
        */
        //Debug.Log(rb.velocity.y);


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
            
        }

        animator.SetFloat("jump", rb.velocity.y);
        animator.SetBool("grounded", isGrounded);



        if (Input.GetKeyDown(KeyCode.X))  {
            animator.SetTrigger("death");
        }

        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            animator.SetTrigger("heal");
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            animator.SetTrigger("attack");

        }


    }

    


    void OnCollisionEnter2D(Collision2D col) {
        isGrounded = true;
        if (col.gameObject.tag == "Barrel")
        {
            Destroy(animator.gameObject);
        }
    }
}
