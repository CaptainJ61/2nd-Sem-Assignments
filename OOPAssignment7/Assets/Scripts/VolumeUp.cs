/*
 * James Difiglio
 * VolumeUp
 * OOP Assignment 7
 * Concrete Command class
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeUp : Command
{
    VolumeReceiver volume;
    Stack<float> volumeHistory;

    public VolumeUp(VolumeReceiver newVolume)
    {
        this.volume = newVolume;
        volumeHistory = new Stack<float>();
    }

    public void Execute()
    {
        volumeHistory.Push(volume.GetCurrentSetting());
        volume.RaiseVolume();
    }

    public void Undo()
    {
        if (volumeHistory.Count != 0)
        {
            volume.gameObject.GetComponent<Slider>().value = volumeHistory.Pop();
        }
    }
}
