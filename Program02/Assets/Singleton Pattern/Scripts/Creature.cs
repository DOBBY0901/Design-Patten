using Unity.VisualScripting;
using UnityEngine;

public abstract class Creature : MonoBehaviour
{
    [SerializeField] protected float Speed;
  
    protected void Update()
    {
     if (GameManager.Instance.State == false) return;

            Behaviour();
    }

    public abstract void Behaviour();
}
