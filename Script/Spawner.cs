using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject ObstaclePrefab;
    public GameObject CollectiblePrefab;
    public float SpawnInterval = 2f;
    // Start is called before the first frame update

    void Start()
    {
        StartCoroutine(SpawnCollectiblesAndObstacle());
    }

    public IEnumerator SpawnCollectiblesAndObstacle()
    {
        while (true)
        {
            SpawnCollectible();
            SpawnObstacle();
            yield return new WaitForSeconds(SpawnInterval);


        }

    }
    public void SpawnCollectible()
    {
        if (CollectiblePrefab != null)
        {
            float spawnX = Random.Range(-10f, 10f);
            Vector3 SpawnPosition = new Vector3(spawnX, Random.Range(-2f, 2f), 0);
            Instantiate(CollectiblePrefab, SpawnPosition, Quaternion.identity);
        }
    }
    public void SpawnObstacle()
    {
        if (ObstaclePrefab != null)
        {

            float spawnX = Random.Range(-10f, 10f);
            Vector3 SpawnPosition = new Vector3(spawnX, Random.Range(-2f, 2f), 0);
            Instantiate(ObstaclePrefab, SpawnPosition, Quaternion.identity);
        }
    }
}

// Update is called once per frame
