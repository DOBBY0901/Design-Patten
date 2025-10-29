using System.Collections;
using UnityEngine;

public class CreateManager : MonoBehaviour
{
    [SerializeField] GameObject gameobject;
    [SerializeField] float createtime;

   
    void Start()
    {
       StartCoroutine(Create());
    }

    IEnumerator Create()
    {
        while (true)
        {
            Instantiate(gameobject, transform.position, Quaternion.identity);
            yield return new WaitForSeconds(createtime);
        }
    }
}

