﻿/*
 * James Difiglio
 * InventoryItem
 * OOP Assignment 2
 * Parent Abstract Class
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class InventoryItem : MonoBehaviour
{
    public double weight;
    public int rating;
    public string itemName;

    public UseLimit useLimit { get; set; }
    public ItemFunction itemFunction { get; set; }

    public virtual void UseItem() { itemFunction.ItemType(); }
    public virtual void ItemUseLimit() { useLimit.durability(); }

    public abstract void ShowStats();

}
