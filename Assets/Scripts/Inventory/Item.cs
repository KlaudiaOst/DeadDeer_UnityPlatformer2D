using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Item", menuName = "ScriptableObjects/Inventory/Item")]
public class Item : ScriptableObject {
    public ItemType type;
    public Sprite sprite;
    public string itemName;
    public string description;
    public int defaultQuantity;
}
