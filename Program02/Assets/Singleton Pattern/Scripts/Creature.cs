using UnityEngine;

public abstract class Creature : MonoBehaviour
{
    [SerializeField] protected float Speed;

    protected void Update()
    {
        Behaviour();
    }

    public abstract void Behaviour();
}
