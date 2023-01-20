using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : ObjectPool
{
    [SerializeField] private GameObject[] _enemyPrefabs;
    [SerializeField] private float _enemyTimeBetwenSpawn;
    [SerializeField] private Transform[] _spawnPoints;

    private float _spawnTime = 0;

    private void Start()
    {
        Initialize(_enemyPrefabs);
    }

    private void Update()
    {
        _spawnTime += Time.deltaTime;

        if(_spawnTime >= _enemyTimeBetwenSpawn)
        {
            if(TryGetObject(out GameObject enemy))
            _spawnTime = 0;

            int spawnPointNumber = Random.Range(0, _spawnPoints.Length);
            if (ObjectPool.score <= 4) 
            {
                SetEnemy(enemy, _spawnPoints[spawnPointNumber].position);
            }
                
        }
    }

    private void SetEnemy(GameObject enemy, Vector3 spawnPoint)
    {
        enemy.SetActive(true);
        enemy.transform.position = spawnPoint;
    }
}

