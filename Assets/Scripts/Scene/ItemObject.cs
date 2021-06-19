using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemObject : MonoBehaviour
{
    public Item item;
    private bool isCollision;
    private Inventory inventory;
    

    void Start()
    {
        isCollision = false;
        GameObject inventoryOBJ = GameObject.Find("Inventory");
        inventory = inventoryOBJ.GetComponent<Inventory>();

        //GetComponent<SpriteRenderer>().sprite = item.sprite;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F) && isCollision)
        {
           if (inventory.PickUp(item))
            {
                Destroy(gameObject);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isCollision = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isCollision = false;
        }
    }
}
