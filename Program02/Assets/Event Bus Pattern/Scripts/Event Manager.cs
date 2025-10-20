using System;
using System.Collections.Generic;
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
      
    }
}
