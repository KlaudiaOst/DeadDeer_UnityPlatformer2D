using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    Animator animator;
    bool doorOpen;

    void Start()
    {
        doorOpen = false;
        animator = GetComponent<Animator>();
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            doorOpen = true;
            Debug.Log("otwarte");
            DoorControl("open");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (doorOpen)
        {
            doorOpen = false;
            Debug.Log("zamkniete");
            DoorControl("close");
        }
    }

    void DoorControl(string directions)
    {
        animator.SetTrigger(directions);
    }
}
