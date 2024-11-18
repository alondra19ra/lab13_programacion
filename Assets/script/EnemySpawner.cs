using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab;

    public float spawnInterval = 2.0f;

    public float minY = -7.8f;
    public float maxY = 7.97f;

  
    public float minX = 0.0f;  

    void Start()
    {
        InvokeRepeating("SpawnEnemy", 0f, spawnInterval);
    }

    void SpawnEnemy()
    {
        float randomY = Random.Range(minY, maxY);

        float randomX = Random.Range(minX, Screen.width);  

        Vector2 spawnPosition = Camera.main.ScreenToWorldPoint(new Vector2(randomX, 0));  

        spawnPosition.y = randomY;

        Instantiate(enemyPrefab, spawnPosition, transform.rotation);
    }
}

