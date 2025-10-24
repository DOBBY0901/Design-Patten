using UnityEngine;

public class Rifle : Weapon
{
    [SerializeField] GameObject bullet;
    [SerializeField] Transform muzzle;
    public override void Attack()
    {
       Instantiate(bullet, muzzle.position, Quaternion.Euler(90,0,0));
       Debug.Log("Rifle fire");
    }
}
