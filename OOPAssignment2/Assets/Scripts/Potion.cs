using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potion : InventoryItem
{
    private double heal;

    private void Awake()
    {
        useLimit = gameObject.AddComponent<OneTimeUse>();
        itemFunction = gameObject.AddComponent<Heal>();
    }

    public Potion(double weight, int rating, string itemName, double heal)
    {
        this.weight = weight;
        this.rating = rating;
        this.itemName = itemName;
        this.heal = heal;
    }



    public override void ShowStats()
    {
        Debug.Log("Item stats:\nWeight: " + weight + "\nRating: " + rating + "\nItem Name: " + itemName + "\nHeal: " + heal);
    }
}
