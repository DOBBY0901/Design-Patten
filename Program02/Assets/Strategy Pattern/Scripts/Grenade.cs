using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class Grenade : Weapon
{
    [SerializeField] Renderer target;
    [SerializeField] Color basiccolor;
    [SerializeField] Color changecolor;

    [SerializeField] float cooltime;
    bool iscooltime;
    public override void Attack()
    {

        if (iscooltime)
        {
            Debug.Log("cooltime");
            return;
        }

        Debug.Log("Throw Grenade");

        if (!iscooltime)
        {
            StartCoroutine(cooltimeroutine());
        }
    }

    IEnumerator cooltimeroutine()
    {
        iscooltime = true;
        target.material.color = changecolor;

        yield return new WaitForSeconds(cooltime);

        target.material.color = basiccolor;
        iscooltime=false;

        Debug.Log("Cooltime Over");
    }
}
