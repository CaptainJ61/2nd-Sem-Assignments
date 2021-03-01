/*
 * James Difiglio
 * Potion
 * OOP Assignment 1
 * Concrete Class # 2
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Potion : InventoryItem, UsePotion
{
    private double heal;

    public Potion(double weight, int rating, string itemName, double heal)
    {
        this.weight = weight;
        this.rating = rating;
        this.itemName = itemName;
        this.heal = heal;
    }

    public void PotionHeal()
    {
        Debug.Log("Heal with " + itemName + " for " + heal + " health");
    }

    public override void ShowStats()
    {
        Debug.Log("Item stats:\nWeight: " + weight + "\nRating: " + rating + "\nItem Name: " + itemName + "\nHeal: " + heal);
    }
}
