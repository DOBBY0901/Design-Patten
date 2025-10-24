using UnityEngine;

public class Knife : Weapon
{
    [SerializeField] Animation knifeattack;
    bool animationplay;


    private void Awake()
    {
        knifeattack.GetComponent<Animation>();
    }

    public override void Attack()
    {
        if (animationplay)
        {
            
        }
    }
}
