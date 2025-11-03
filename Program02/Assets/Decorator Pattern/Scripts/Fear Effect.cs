using UnityEngine;

public class FearEffect : Decorator
{
    public FearEffect(IStatus status) : base(status)
    {

    }

    public override void Update()
    {
        base.Update();

        Debug.Log("공포 상태");
    }
}
