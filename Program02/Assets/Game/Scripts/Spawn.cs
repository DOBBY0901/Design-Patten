using System.Collections;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    [SerializeField] GameObject enemy;
   
    [SerializeField] float minDelay; //스폰간격
    [SerializeField] float maxDelay;
    
    [SerializeField] float minX; //스폰 x좌표
    [SerializeField] float maxX;

    [SerializeField] float minY; //스폰 y좌표
    [SerializeField] float maxY;

    [SerializeField] int minCount; // 소환개수
    [SerializeField] int maxCount;

   
    void Start()
    {
        StartCoroutine(EnemySpawn());
    }

   
    IEnumerator EnemySpawn()
    {
        while (true)
        {
            float delay = Random.Range(minDelay, maxDelay);
            yield return new WaitForSeconds(delay);

            int spawncount = Random.Range(minCount, maxCount);

            for (int i = 0; i < spawncount; i++)
            {
                float spawnX = Random.Range(minX, maxX);
                float spawnY = Random.Range(minY, maxY);

                Vector3 spawnPosition = new Vector3(spawnX, spawnY, 0);
                Instantiate(enemy, spawnPosition, Quaternion.identity);    
            }

        }
        
    }
}
