using UnityEngine;

public class SlienceEffect : Decorator
{
    public SlienceEffect(IStatus status) : base(status)
    {
        
    }

    public override void Update()
    {
        base.Update();

        Debug.Log("Ä§¹¬ »óÅÂ");
    }
}
