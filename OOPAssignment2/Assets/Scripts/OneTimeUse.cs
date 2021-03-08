/*
 * James Difiglio
 * OneTimeUse
 * OOP Assignment 2
 * Behavior subclass
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OneTimeUse : UseLimit
{
    public override void durability()
    {
        Debug.Log("The empty bottle gets tossed away and replaced with a new potion.");//Item deletes after use
        GetComponent<Text>().text = "The empty bottle gets tossed away and replaced with a new potion.";
    }
}
