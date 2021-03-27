/*
 * James Difiglio
 * RemoteButton
 * OOP Assignment 7
 * Invoker class
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RemoteButton : MonoBehaviour
{
    public VolumeReceiver volumeReceiver;
    public ActivationReceiver activationReceiver;
    private Command volumeUp;
    private Command volumeDown;
    private Command tvOn;
    private Command tvOff;

    public Stack<Command> commandHistory;

    // Start is called before the first frame update
    void Awake()
    {
        volumeUp = new VolumeUp(volumeReceiver);
        volumeDown = new VolumeDown(volumeReceiver);
        tvOn = new TVOn(activationReceiver);
        tvOff = new TVOff(activationReceiver);
        commandHistory = new Stack<Command>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            volumeUp.Execute();

            commandHistory.Push(volumeUp);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            volumeDown.Execute();

            commandHistory.Push(volumeDown);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            tvOn.Execute();

            commandHistory.Push(tvOn);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            tvOff.Execute();

            commandHistory.Push(tvOff);
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (commandHistory.Count != 0)
            {
                Command lastCommand = commandHistory.Pop();

                lastCommand.Undo();
            }
        }
    }
}
