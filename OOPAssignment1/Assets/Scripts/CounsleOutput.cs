using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CounsleOutput : MonoBehaviour
{
    public InventoryItem sword;
    public InventoryItem commonPotion;

    
    public List<InventoryItem> inventoryList = new List<InventoryItem>();
    public List<UseWeapon> weaponList = new List<UseWeapon>();
    public List<UsePotion> potionList = new List<UsePotion>();


    // Start is called before the first frame update
    void Start()
    {

        sword = new Weapon(5.0, 1, "Sword", 4.0);
        commonPotion = new Potion(1.0, 1, "Common Potion", 6.0);

        //part 1
        sword.ShowStats();
        commonPotion.ShowStats();
        
        //part 2
        inventoryList.Add(new Weapon(5.0, 1, "Sword", 4.0));
        inventoryList.Add(new Potion(1.0, 1, "Common Potion", 6.0));
        inventoryList.Add(new Weapon(5.5, 2, "Axe", 5.0));
        inventoryList.Add(new Potion(1.0, 3, "Greater Potion", 10.0));

        //part 4
        weaponList.Add(new Weapon(5.0, 1, "Sword", 4.0));
        weaponList.Add(new Weapon(5.5, 2, "Axe", 5.0));
        potionList.Add(new Potion(1.0, 1, "Common Potion", 6.0));
        potionList.Add(new Potion(1.0, 3, "Greater Potion", 10.0));

        //part 5
        inventoryList.Add(new HealingStaff(3.0, 2, "Healing Staff", 2, 3));
        weaponList.Add(new HealingStaff(3.0, 2, "Healing Staff", 2, 3));
        potionList.Add(new HealingStaff(3.0, 2, "Healing Staff", 2, 3));
    }

    // Update is called once per frame
    void Update()
    {
        //part 3
        foreach (InventoryItem item in inventoryList)
        {
            if (Input.GetKeyDown(KeyCode.Alpha1))
            {
                item.ShowStats();
            }
        }

        //part 4
        foreach (UseWeapon item in weaponList)
        {
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                item.WeaponAttack();
            }
        }
        foreach (UsePotion item in potionList)
        {
            if (Input.GetKeyDown(KeyCode.Alpha2))
            {
                item.PotionHeal();
            }
        }



    }
}
