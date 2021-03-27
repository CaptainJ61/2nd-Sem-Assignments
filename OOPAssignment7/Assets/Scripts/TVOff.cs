/*
 * James Difiglio
 * TVOff
 * OOP Assignment 7
 * Concrete Command class
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TVOff : Command
{
    ActivationReceiver activation;
    Stack<Color> activationHistory;

    public TVOff(ActivationReceiver newActivation)
    {
        this.activation = newActivation;
        activationHistory = new Stack<Color>();
    }

    public void Execute()
    {
        activationHistory.Push(activation.GetCurrentState());
        activation.TurnTVOff();
    }

    public void Undo()
    {
        if (activationHistory.Count != 0)
        {
            activation.gameObject.GetComponent<MeshRenderer>().material.color = activationHistory.Pop();
        }
    }
}
