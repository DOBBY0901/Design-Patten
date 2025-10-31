using UnityEngine;

public class SlowEffect : IStatus
{
    void IStatus.Apply()
    {
        throw new System.NotImplementedException();
    }

    void Start()
    {
        Debug.Log("Slow!");
    }

    void IStatus.Update()
    {
        throw new System.NotImplementedException();
    }
}
