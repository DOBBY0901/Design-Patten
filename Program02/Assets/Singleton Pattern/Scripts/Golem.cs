using UnityEngine;

public class Golem : Creature
{

    [SerializeField] float targetY;
    [SerializeField] Vector3 originPosition;

    private void Start()
    {
       originPosition = transform.position;
    }
    public override void Behaviour()
    {
        float offset = Mathf.PingPong(Time.time * Speed, targetY);

        transform.position = originPosition + new Vector3(0,offset,0);
    }
}

