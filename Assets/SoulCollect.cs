using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoulCollect : MonoBehaviour
{
    Animator animator;
    bool soulCollect;
    public int collect;
    public int count;
    void Start()
    {
        soulCollect = false;
        animator = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && !soulCollect)
        {
            soulCollect = true;
            animator.SetTrigger("collect");

            collision.gameObject.GetComponent<PlayerSouls>().SoulsCount(count);
            Destroy(animator.gameObject, 1f);
        }
    }
    
}
