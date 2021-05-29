using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollect : MonoBehaviour
{
    Animator animator;
    bool coinCollect;
    public int collect;
    public int count;
    
    
    void Start()
    {
        coinCollect = false;
        animator = GetComponent<Animator>();
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player" && !coinCollect)
        {
            //PlayerScore.scoreValue += 1;
            coinCollect = true;
            animator.SetTrigger("collect");

            collision.gameObject.GetComponent<PlayerScore>().ScoreCount(count);
            Destroy(animator.gameObject, 1f);
        }
    }
    //private void OnTriggerExit2D(Collider2D collision)
    //{
    //    if (coinCollect)
    //    {
    //        coinCollect = false;
           


    //    }
    //}

}
