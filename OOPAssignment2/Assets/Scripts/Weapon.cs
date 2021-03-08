/*
 * James Difiglio
 * Weapon
 * OOP Assignment 2
 * Client class
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : InventoryItem
{
    private double damage;

    private void Awake()
    {
        useLimit = gameObject.AddComponent<MultiUse>();
        itemFunction = gameObject.AddComponent<Attack>();
    }

    public Weapon(double weight, int rating, string itemName, double damage)
    {
        this.weight = weight;
        this.rating = rating;
        this.itemName = itemName;
        this.damage = damage;
    }

    

    public override void ShowStats()
    {
        Debug.Log("Item stats:\nWeight: " + weight + "\nRating: " + rating + "\nItem Name: " + itemName + "\nDamage: " + damage);
    }

}
