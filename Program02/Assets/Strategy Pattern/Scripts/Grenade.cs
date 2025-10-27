using System.Collections;
using Unity.VisualScripting;
using UnityEngine;

public class Grenade : Weapon
{
    [SerializeField] MeshRenderer meshRenderer;
    [SerializeField] Coroutine coroutine;
   
    [SerializeField] Material[ ] materials;

    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>();
    }

    public override void Attack()
    {
        coroutine = StartCoroutine(Activate());
        
        if (coroutine == null)
        {
            coroutine = StartCoroutine(Activate());
        }
    }

    IEnumerator Activate()
    {
        meshRenderer.material = materials[0];

        yield return new WaitForSeconds(3.0f);

        meshRenderer.material = materials[1];

        coroutine = null; 
    }

}
