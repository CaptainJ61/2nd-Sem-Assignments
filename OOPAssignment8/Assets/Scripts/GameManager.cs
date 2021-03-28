using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject text;

    Shield shield;
    Sword sword;
    Vest vest;

    // Start is called before the first frame update
    void Start()
    {
        text.GetComponent<Text>().text = "";

        shield = new Shield();
        sword = new Sword();
        vest = new Vest();

    }

    // Update is called once per frame
    void Update()
    {
        //this activates the template method
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            text.GetComponent<Text>().text = shield.Craft();
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            text.GetComponent<Text>().text = sword.Craft();
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            text.GetComponent<Text>().text = vest.Craft();
        }

        //this controls the hook operation
        if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            shield.haveMaterials = false;
            sword.haveMaterials = false;
            vest.haveMaterials = false;
        }
        if (Input.GetKeyDown(KeyCode.Alpha9))
        {
            shield.haveMaterials = true;
            sword.haveMaterials = true;
            vest.haveMaterials = true;
        }
    }
}
