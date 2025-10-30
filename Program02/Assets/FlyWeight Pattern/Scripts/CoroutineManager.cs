using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public static class CoroutineManager
{
    private static Dictionary<float, WaitForSeconds> dictionary = new();
    public static WaitForSeconds GetCachedWait(float time)
    {
        WaitForSeconds waitForSeconds = null;

        if (!dictionary.TryGetValue(time, out waitForSeconds))
        {
            dictionary.Add(time, new WaitForSeconds(time));

            waitForSeconds = dictionary[time];
        }
        
        return waitForSeconds;
    }
}
