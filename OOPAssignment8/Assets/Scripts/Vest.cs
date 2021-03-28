using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vest : Crafter
{
    public bool haveMaterials = true;
    public override string MaterialType()
    {
        return "leather";
    }
    public override bool HaveMaterials()
    {
        return haveMaterials;
    }
}
