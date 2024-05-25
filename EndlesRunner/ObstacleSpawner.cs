using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    private GameObject[] obstacles;
    public float minSpawnTime = 1f, maxSpawnTime = 3f, maxX = 5f, minX = -5f;

    // Start is called before the first frame update
    void Start()
    {
        obstacles = Resources.LoadAll<GameObject>("Obstacles");
        SpawnObstacle();
    }

    // Update is called once per frame
    void SpawnObstacle()
    {
        int random = Random.Range(0, obstacles.Length-1);
        float randomX = Random.Range(minX, maxX);
        Vector3 spawnPosition = new Vector3(randomX, transform.position.y, transform.position.z);

        Instantiate(obstacles[random], spawnPosition, Quaternion.identity, transform);
        float SpawnDelay = Random.Range(minSpawnTime,maxSpawnTime);
        Invoke("SpawnObstacle", SpawnDelay);

    }
}
