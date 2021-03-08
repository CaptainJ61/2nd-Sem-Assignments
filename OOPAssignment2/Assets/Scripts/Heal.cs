using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Heal : ItemFunction
{
    public override void ItemType()
    {
        Debug.Log("You drink the potion and it heals you.");//item heals player
        GetComponent<Text>().text = "You drink the potion and it heals you.";
    }
}
