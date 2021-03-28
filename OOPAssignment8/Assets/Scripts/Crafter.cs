using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Crafter : MonoBehaviour
{
    
    //template method
    public string Craft()
    {
        if (HaveMaterials())
        {
            return "Gathering " + MaterialType() + " from inventory for a " + GetType() + "." + Assembly() +
                "\nThe " + GetType() + " was finished and stored in your inventory.";
        } else
        {
            return "Gathering " + MaterialType() + " from inventory for a " + GetType() + "." + Assembly() +
                "\nHowever you lacked the materials to complete the " + GetType() + " and returned the rest to your inventory.";
        }
    }
    //concrete method
    string Assembly()
    {
        return "\nAssemblying the gathererd materials.";
    }
    //abstract method
    public abstract string MaterialType();
    //hook operation
    public virtual bool HaveMaterials()
    {
        return true;
    }

}
