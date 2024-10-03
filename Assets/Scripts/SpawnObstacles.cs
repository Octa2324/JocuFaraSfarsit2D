using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacles : MonoBehaviour
{
    public GameObject obstacle;            
    public GameObject bossObstacle;        
    public float maxX;                     
    public float maxY;                     
    public float minX;                     
    public float minY;                     
    public float timeBetweenSpawn = 2f;    
    private float spawnTime;               

    public float bossSpawnInterval = 2f;  //10f
    private float bossSpawnTime;           

    void Start()
    {
        spawnTime = Time.time + timeBetweenSpawn; 
        bossSpawnTime = Time.time + bossSpawnInterval; 
    }

    void Update()
    {
       if (Time.time > spawnTime)
        {
            SpawnRegularObstacle();
            spawnTime = Time.time + timeBetweenSpawn;
        } 

        if (Time.time > bossSpawnTime)
        {
            SpawnBossObstacle();
            bossSpawnTime = Time.time + bossSpawnInterval;
        }
    }

    void SpawnRegularObstacle()
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);

        Instantiate(obstacle, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
    }

    void SpawnBossObstacle()
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);

        Instantiate(bossObstacle, transform.position + new Vector3(randomX, randomY, 0), transform.rotation);

    }
}
