/*
 * James Difiglio
 * VolumeReceiver
 * OOP Assignment 7
 * Receiver class
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeReceiver : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Slider>().value = 5;
    }

    public float GetCurrentSetting()
    {
        return GetComponent<Slider>().value;
    }

    public void RaiseVolume()
    {
        GetComponent<Slider>().value += 1;
    }
    public void LowerVolume()
    {
        GetComponent<Slider>().value -= 1;
    }
}
