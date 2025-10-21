using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;

public enum Condition
{
    START,
    PAUSE,
    FINISH
}
public static class EventManager
{
    static Dictionary<Condition, Action> dicitionary = new();

    public static void Subscribe(Condition condition, Action action)
    {
        if (dicitionary.ContainsKey(condition))
        {
            dicitionary[condition] += action;
        }
        else
        {
            dicitionary[condition] = action; // .Add를 해도 상관없음.
        }
    }

    public static void Unsubscribe(Condition condition, Action action)
    {
        if (dicitionary.ContainsKey(condition))
        {
            dicitionary[condition] -= action;
        }
        else
        {
            return;
        }
    }

    public static void Publish(Condition condition)
    {
        if (dicitionary.TryGetValue(condition, out var action))
        {
            action?.Invoke();
        }
        
    }
}
