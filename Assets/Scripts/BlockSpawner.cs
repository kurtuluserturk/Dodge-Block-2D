using UnityEngine;

public class BlockSpawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject blockPrefab;
    float spawnTime = 2f;
    float timeBetweenSpawn = 1.5f;       
    void Update()
    {
        if(Time.time >= spawnTime)
        {
            SpawnBlock();
            spawnTime = Time.time + timeBetweenSpawn;
        }                
    }
    void SpawnBlock()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length);
        for (int i = 0; i < spawnPoints.Length; i++)
        {
            if (i != randomIndex)
            {
                Instantiate(blockPrefab, spawnPoints[i].position, Quaternion.identity);
            }
        }
    }
}
