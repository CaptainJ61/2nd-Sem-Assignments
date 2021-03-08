/*
 * James Difiglio
 * MultiUse
 * OOP Assignment 2
 * Behavior subclass
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MultiUse : UseLimit
{
    public override void durability()
    {
        Debug.Log("This item can be used again.");//Item can be used again
        GetComponent<Text>().text = "This item can be used again.";
    }
}
