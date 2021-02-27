using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class InventoryItem
{
    public double weight;
    public int rating;
    public string itemName;

    public InventoryItem()
    {
        weight = 0.0;
        rating = 0;
        itemName = "";
    }

    public abstract void ShowStats();

}
