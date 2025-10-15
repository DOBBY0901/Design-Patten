using UnityEngine;

public class Mushroom : Creature
{
    [SerializeField] Vector3 originSize;
    [SerializeField] float maxSize;
    
    private void Start()
    {
        maxSize = 3;
        originSize =  transform.localScale; 
    }

    public override void Behaviour()
    {
       float offset = Mathf.PingPong(Time.time * Speed, maxSize);

        transform.localScale = originSize + new Vector3(offset, offset, offset);
    }
}
