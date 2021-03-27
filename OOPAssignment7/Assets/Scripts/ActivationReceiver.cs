/*
 * James Difiglio
 * ActivationReceiver
 * OOP Assignment 7
 * Receiver class
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivationReceiver : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<MeshRenderer>().material.color = Color.black;
    }

    public Color GetCurrentState()
    {
        return GetComponent<MeshRenderer>().material.color;
    }

    public void TurnTVOn()
    {
        GetComponent<MeshRenderer>().material.color = Color.blue;
    }
    public void TurnTVOff()
    {
        GetComponent<MeshRenderer>().material.color = Color.black;
    }
}
