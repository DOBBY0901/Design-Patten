using UnityEngine;

public class SlowEffect : Decorator
{
    public SlowEffect(IStatus status) : base(status)
    {

    }

    public override void Update()
    {
        base.Update();

        Debug.Log("µÐÈ­ »óÅÂ");
    }
}

