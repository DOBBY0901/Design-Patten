using System.Collections;
using UnityEngine;
using UnityEngine.SocialPlatforms.GameCenter;

public class SpawnManager : MonoBehaviour
{
    
    [SerializeField] WaitForSeconds waitForSeconds;
    [SerializeField] float radius;

    private void Awake()
    {
        waitForSeconds = new WaitForSeconds(5);
    }
    void Start()
    {
       
       StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        while (true)
        {
            GameObject bee = ObjectPool.Instance.GetObject();

            Vector2 direction = Random.insideUnitCircle.normalized * radius;

            bee.transform.position = new Vector3(direction.x, 0, direction.y);

            yield return waitForSeconds;
        }
        
    }

}
