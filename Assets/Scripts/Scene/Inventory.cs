using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public List<ItemComponent> items;

    public bool PickUp(Item item)
    {
        foreach(ItemComponent i in items)
        {
            if(i.item == item)
            {
                i.SetItem(item);
                return true;
            }
        }
        foreach (ItemComponent i in items)
        {
            if (i.item == null)
            {
                i.SetItem(item);
                return true;
            }
        }
        
        return false;
    }

}
