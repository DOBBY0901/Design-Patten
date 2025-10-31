using UnityEngine;

public class FearEffect : IStatus
{
    void IStatus.Apply()
    {
        throw new System.NotImplementedException();
    }

    void Start()
    {
        Debug.Log("Fear!");
    }

    void IStatus.Update()
    {
        throw new System.NotImplementedException();
    }
}
