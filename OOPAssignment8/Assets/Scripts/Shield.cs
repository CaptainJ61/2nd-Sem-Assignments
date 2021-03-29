/*
 * James Difiglio
 * Shield
 * OOP Assignment 8
 * Concrete class
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shield : Crafter
{
    public bool haveMaterials = true;
    public override string MaterialType()
    {
        return "wood";
    }
    public override bool HaveMaterials()
    {
        return haveMaterials;
    }
}
