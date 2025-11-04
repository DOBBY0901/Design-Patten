using UnityEngine;

public class SlowEffect : Decorator
{
    [SerializeField] float slowspeed;
  
    public override void Acivate()
    {
        debuff.Acivate();

        Debug.Log("µÐÈ­ »óÅÂ");
    }

}

