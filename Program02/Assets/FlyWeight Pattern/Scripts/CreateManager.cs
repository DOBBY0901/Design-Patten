using System.Collections;
using UnityEngine;

public class CreateManager : MonoBehaviour
{
    [SerializeField] GameObject prefab;
    [SerializeField] Transform createPostion;
    


   
    void Start()
    {
       StartCoroutine(Create());
    }

    IEnumerator Create()
    {
        while (true)
        {
            yield return CoroutineManager.GetCachedWait(Random.Range(1, 6));

            
            Instantiate(prefab, createPostion.position, prefab.transform.rotation);

            
        }
    }
}

