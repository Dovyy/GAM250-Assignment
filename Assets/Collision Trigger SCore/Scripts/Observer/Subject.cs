﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Subject : MonoBehaviour
{

    List<Observer> observers = new List<Observer>();

	public void Notify(EventData data)
    {
        foreach (Observer o in observers)
            o.OnNotify(data);
    }

    public void AddObserver(Observer o)
    {
        observers.Add(o);
    }

    public void RemoveObserver(Observer o)
    {
        observers.Remove(o);
    }
}
