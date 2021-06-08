using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HiddenRoom : MonoBehaviour
{

    public SpriteRenderer[] wallEmlements;
    float alphaValue = 1f;

    public float disappearRate = 1f;
    bool playerEntered = false;

    public bool toggleWall = false;

    void Update()
    {
        if (playerEntered)
        {
            alphaValue -= Time.deltaTime * disappearRate;

            if (alphaValue <= 0)
                alphaValue = 0;

            foreach (SpriteRenderer wallItem in wallEmlements)
            {
                wallItem.color = new Color(wallItem.color.r, wallItem.color.g, wallItem.color.b, alphaValue);
            }
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            playerEntered = true;
        }
    }
}
