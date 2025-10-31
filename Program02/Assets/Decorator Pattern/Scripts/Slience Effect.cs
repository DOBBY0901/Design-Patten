using UnityEngine;

public class SlienceEffect : IStatus
{
    void IStatus.Apply()
    {
        throw new System.NotImplementedException();
    }

    void Start()
    {
        Debug.Log("Slience!");
    }

    void IStatus.Update()
    {
        throw new System.NotImplementedException();
    }
}
