using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Attack : ItemFunction
{
    public override void ItemType()
    {
        Debug.Log("You swing your weapon at the enemy.\n*And then miss becuase there is no enemy*");//Player attacks with item
        GetComponent<Text>().text = "You swing your weapon at the enemy.\n*And then miss becuase there is no enemy*";
    }
}
