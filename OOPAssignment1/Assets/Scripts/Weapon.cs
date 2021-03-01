/*
 * James Difiglio
 * Weapon
 * OOP Assignment 1
 * Concrete Class # 1
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : InventoryItem, UseWeapon
{
    private double damage;

    public Weapon(double weight, int rating, string itemName, double damage)
    {
        this.weight = weight;
        this.rating = rating;
        this.itemName = itemName;
        this.damage = damage;
    }

    public void WeaponAttack()
    {
        Debug.Log("Attack with " + itemName + " for " + damage + " damage");
    }

    public override void ShowStats()
    {
        Debug.Log("Item stats:\nWeight: " + weight + "\nRating: " + rating + "\nItem Name: " + itemName + "\nDamage: " + damage);
    }

}
