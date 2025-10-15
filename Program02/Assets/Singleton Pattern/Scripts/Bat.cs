using UnityEngine;

public class Bat : Creature
{

    [SerializeField] Vector3 direction;

    private void Start()
    {
        direction = Vector3.up;
    }

    public override void Behaviour()
    {
        transform.Rotate(direction, Speed * Time.deltaTime);
    }
}
