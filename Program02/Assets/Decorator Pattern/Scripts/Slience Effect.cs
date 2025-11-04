using UnityEngine;

public class SlienceEffect : Decorator
{
    public override void Acivate()
    {
        debuff.Acivate();
        
        Debug.Log("µÐÈ­ »óÅÂ");
    }
}
