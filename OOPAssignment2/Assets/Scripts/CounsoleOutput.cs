using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CounsoleOutput : MonoBehaviour
{
    public GameObject consoleOutput;
    public GameObject consoleOutput2;

    public int itemType;
    

    // Start is called before the first frame update
    void Start()
    {
        consoleOutput.AddComponent<Weapon>();
        consoleOutput2.AddComponent<Weapon>();
        itemType = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (itemType == 1)
            {
                consoleOutput.GetComponent<Weapon>().UseItem();
                consoleOutput2.GetComponent<Weapon>().ItemUseLimit();
            }
            else if (itemType == 2)
            {
                consoleOutput.GetComponent<Potion>().UseItem();
                consoleOutput2.GetComponent<Potion>().ItemUseLimit();
            }
            
            
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Destroy(consoleOutput.GetComponent<Weapon>());
            Destroy(consoleOutput.GetComponent<MultiUse>());
            Destroy(consoleOutput.GetComponent<Attack>());

            Destroy(consoleOutput2.GetComponent<Weapon>());
            Destroy(consoleOutput2.GetComponent<MultiUse>());
            Destroy(consoleOutput2.GetComponent<Attack>());

            consoleOutput.AddComponent<Weapon>();
            consoleOutput2.AddComponent<Weapon>();

            Destroy(consoleOutput.GetComponent<Potion>());
            Destroy(consoleOutput.GetComponent<OneTimeUse>());
            Destroy(consoleOutput.GetComponent<Heal>());

            Destroy(consoleOutput2.GetComponent<Potion>());
            Destroy(consoleOutput2.GetComponent<OneTimeUse>());
            Destroy(consoleOutput2.GetComponent<Heal>());

            itemType = 1;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Destroy(consoleOutput.GetComponent<Potion>());
            Destroy(consoleOutput.GetComponent<OneTimeUse>());
            Destroy(consoleOutput.GetComponent<Heal>());

            Destroy(consoleOutput2.GetComponent<Potion>());
            Destroy(consoleOutput2.GetComponent<OneTimeUse>());
            Destroy(consoleOutput2.GetComponent<Heal>());

            consoleOutput.AddComponent<Potion>();
            consoleOutput2.AddComponent<Potion>();

            Destroy(consoleOutput.GetComponent<Weapon>());
            Destroy(consoleOutput.GetComponent<MultiUse>());
            Destroy(consoleOutput.GetComponent<Attack>());

            Destroy(consoleOutput2.GetComponent<Weapon>());
            Destroy(consoleOutput2.GetComponent<MultiUse>());
            Destroy(consoleOutput2.GetComponent<Attack>());

            itemType = 2;

        }
    }
}
