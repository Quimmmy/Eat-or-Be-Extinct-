using System.Collections;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    [Header("Prefabs to Spawn")]
    [SerializeField] GameObject[] objectsToSpawn;

    [Header("Spawn Points")]
    [SerializeField] Transform[] spawnPoints;

    [Header("Spawn Timing")]
    [SerializeField] float spawnInterval = 0.5f;   // time between spawns
    [SerializeField] float destroyTime = 5f;       // how long before object disappears

    void Start()
    {
        StartCoroutine(SpawnRoutine());
    }

    IEnumerator SpawnRoutine()
    {
        while (true)
        {
            // Random prefab
            GameObject prefab = objectsToSpawn[Random.Range(0, objectsToSpawn.Length)];

            // Random spawn point
            Transform spawnPoint = spawnPoints[Random.Range(0, spawnPoints.Length)];

            // Spawn object
            GameObject spawned = Instantiate(prefab, spawnPoint.position, Quaternion.identity);

            // Destroy after X seconds
            Destroy(spawned, destroyTime);

            // Wait before next spawn
            yield return new WaitForSeconds(spawnInterval);
        }
    }
}
