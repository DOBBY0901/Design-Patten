using Unity.VisualScripting;
using UnityEngine;

public class Character : Debuff
{
    public Animator animator;   
    [SerializeField] IStateable stateable;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    private void Start()
    {
        stateable = new Idle();
    }

    private void Update()
    {
        stateable.Update(this);
    }
    public void Changestate(IStateable newstateble)
    {
       stateable?.Exit(this);
       stateable = newstateble;
       stateable.Enter(this);
    }

    public override void Acivate()
    {
        Debug.Log("Character");
    }
}
