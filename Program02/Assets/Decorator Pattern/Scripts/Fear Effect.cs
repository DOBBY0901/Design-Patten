using UnityEngine;

public class FearEffect : Decorator
{
    public override void Acivate()
    {
        debuff.Acivate();

        Debug.Log("공포 상태");
    }
}
