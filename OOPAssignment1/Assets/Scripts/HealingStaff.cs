using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealingStaff : InventoryItem, UseWeapon, UsePotion
{
    private double damage;
    private double heal;

    public HealingStaff(double weight, int rating, string itemName, double damage, double heal)
    {
        this.weight = weight;
        this.rating = rating;
        this.itemName = itemName;
        this.damage = damage;
        this.heal = heal;
    }

    public override void ShowStats()
    {
        Debug.Log("Item stats:\nWeight: " + weight + "\nRating: " + rating + "\nItem Name: " + itemName + "\nDamage: " + damage + "\nHeal: " + heal);
    }

    public void WeaponAttack()
    {
        Debug.Log("Attack with " + itemName + " for " + damage + " damage");
    }

    public void PotionHeal()
    {
        Debug.Log("Heal with " + itemName + " for " + heal + " health");
    }
}
