using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour {
    public float speed = 10;
    public float jumpForce = 800;

    private Rigidbody2D rb;

    private bool isGrounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;

    private Animator animator;
    private float prev;
    private float current;

    private bool facingRight = true;

    private int extraJumps;
    public int extraJumpsValue;

    private bool sprint;
    public float _sprint;
    public float AfterSprintSpeed;


    
    void Start() {
        extraJumps = extraJumpsValue;
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        isGrounded = true;
       // prev = transform.position.y;
       // current = transform.position.y;
    }

    
    void Update() {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            sprint = true;
        }
        ////if (sprint = true)
        ////{
        ////    speed = _sprint;
        ////}
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            sprint = false;
        }

        float xDisplacement = Input.GetAxis("Horizontal");// * speed;
        if (sprint)
        {
            xDisplacement *= _sprint;
        }
        else
        {
            xDisplacement *= speed;
        }
        rb.velocity = new Vector2(xDisplacement, rb.velocity.y);
        animator.SetFloat("speed", rb.velocity.x);

        if (facingRight == false && xDisplacement > 0)
        {
            Flip();
        } else if (facingRight == true && xDisplacement <0)
        {
            Flip();
        }

            prev = current;

        void Flip()
        {
            facingRight = !facingRight;
            Vector3 Scaler = transform.localScale;
            Scaler.x *= -1;
            transform.localScale = Scaler;
        }

        
        if(isGrounded == true)
        {
            extraJumps = extraJumpsValue;
        }
        //extrajump
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded ) {
            rb.AddForce(new Vector2(0, jumpForce));
            isGrounded = false;
            extraJumps--;
            
        }else if(Input.GetKeyDown(KeyCode.Space) && isGrounded == false && extraJumps == 0) {
            rb.velocity = new Vector2(0, 0);
            rb.AddForce(new Vector2(0, jumpForce));
            extraJumps--;
        }

        animator.SetFloat("jump", rb.velocity.y);
        animator.SetBool("grounded", isGrounded);



        if (Input.GetKeyDown(KeyCode.X))  {
            animator.SetTrigger("death");
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            animator.SetTrigger("heal");
        }

        if (Input.GetKeyDown(KeyCode.E))
        {
            animator.SetTrigger("attack");

        }

        if (Input.GetKeyDown(KeyCode.Q))
        {           
            animator.SetTrigger("bullet");
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            animator.SetTrigger("specialAttack");
        }


        //fixed update doda?
        //sprint
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            sprint = true;
        }
        ////if (sprint = true)
        ////{
        ////    speed = _sprint;
        ////}
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            sprint = false;
        }
        //if(sprint == false)
        //{
        //    speed = AfterSprintSpeed;
        //}
    }

    


    void OnCollisionEnter2D(Collision2D collision) {

        isGrounded = true;
        extraJumps = extraJumpsValue;

        if (collision.gameObject.CompareTag("Platform"))
        {
            transform.parent = collision.gameObject.transform;
        }

        if (collision.gameObject.tag == "Barrel")
        {
            Destroy(animator.gameObject);
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if ( collision.gameObject.tag == "Platform")
        {
            transform.parent = null;
        }
    }
}
