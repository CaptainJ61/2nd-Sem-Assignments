/*
 * James Difiglio
 * Command
 * OOP Assignment 7
 * Command interface
 */
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Command
{
    void Execute();
    void Undo();
}
