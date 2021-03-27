/*
 * James Difiglio
 * VolumeDown
 * OOP Assignment 7
 * Concrete Command class
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeDown : Command
{
    VolumeReceiver volume;
    Stack<float> volumeHistory;

    public VolumeDown(VolumeReceiver newVolume)
    {
        this.volume = newVolume;
        volumeHistory = new Stack<float>();
    }

    public void Execute()
    {
        volumeHistory.Push(volume.GetCurrentSetting());
        volume.LowerVolume();
    }

    public void Undo()
    {
        if (volumeHistory.Count != 0)
        {
            volume.gameObject.GetComponent<Slider>().value = volumeHistory.Pop();
        }
    }
}
