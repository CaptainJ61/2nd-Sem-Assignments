using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : Crafter
{
    public bool haveMaterials = true;
    public override string MaterialType()
    {
        return "steel";
    }
    public override bool HaveMaterials()
    {
        return haveMaterials;
    }
}
