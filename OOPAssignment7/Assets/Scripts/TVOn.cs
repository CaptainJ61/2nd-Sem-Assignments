/*
 * James Difiglio
 * TVOn
 * OOP Assignment 7
 * Concrete Command class
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TVOn : Command
{
    ActivationReceiver activation;
    Stack<Color> activationHistory;

    public TVOn(ActivationReceiver newActivation)
    {
        this.activation = newActivation;
        activationHistory = new Stack<Color>();
    }

    public void Execute()
    {
        activationHistory.Push(activation.GetCurrentState());
        activation.TurnTVOn();
    }

    public void Undo()
    {
        if (activationHistory.Count != 0)
        {
            activation.gameObject.GetComponent<MeshRenderer>().material.color = activationHistory.Pop();
        }
    }
}
