using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : ObjectPool
{
    [SerializeField] private GameObject[] _enemyPrefabs;
    [SerializeField] private Transform[] _spawnPoints;

    private float _spawnTime;
    private float _enemyTimeBetwenSpawn = 1.2f;

    private void Start()
    {
        //Initialize(_enemyPrefabs);
        switch (GameDifficultySelection.gameDifficultyText)
        {
            case "Легкая":
                Initialize(_enemyPrefabs);
                break;
        }
    }

    private void Update()
    {
        switch (GameDifficultySelection.gameDifficultyText)
        {
            case "Легкая":
                _enemyTimeBetwenSpawn = 1.5f;
                Debug.Log(GameDifficultySelection.gameDifficultyText + _enemyTimeBetwenSpawn);
                break;
            case "Средняя":
                _enemyTimeBetwenSpawn = 1.2f;
                Debug.Log(GameDifficultySelection.gameDifficultyText + _enemyTimeBetwenSpawn);
                break;
            case "Сложная":
                _enemyTimeBetwenSpawn = 1.0f;
                Debug.Log(GameDifficultySelection.gameDifficultyText + _enemyTimeBetwenSpawn);
                break;
            case "Бесконечная":
                _enemyTimeBetwenSpawn = 1.0f;
                Debug.Log(GameDifficultySelection.gameDifficultyText + _enemyTimeBetwenSpawn);
                break;
            default:
                Debug.Log(GameDifficultySelection.gameDifficultyText + _enemyTimeBetwenSpawn);
                break;
        }

        _spawnTime += Time.deltaTime;

        if(_spawnTime >= _enemyTimeBetwenSpawn)
        {
            if(TryGetObject(out GameObject enemy))
            _spawnTime = 0;
            
            int spawnPointNumber = Random.Range(0, _spawnPoints.Length);

            switch (GameDifficultySelection.gameDifficultyText)
            {
                case "Легкая":
                    if (ObjectPool.score <= Score.spawnerActiveEasy)//до какого счета спавнятся мобцы.
                    {
                        SetEnemy(enemy, _spawnPoints[spawnPointNumber].position);
                    }
                    Debug.Log(GameDifficultySelection.gameDifficultyText + "sapwner" + _enemyTimeBetwenSpawn);
                    break;

                case "Средняя":
                    if (ObjectPool.score <= Score.spawnerActiveMedium)//до какого счета спавнятся мобцы.
                    {
                        SetEnemy(enemy, _spawnPoints[spawnPointNumber].position);
                    }
                    Debug.Log(GameDifficultySelection.gameDifficultyText + "sapwner" + _enemyTimeBetwenSpawn);
                    break;

                case "Сложная":
                    if (ObjectPool.score <= Score.spawnerActiveHard)//до какого счета спавнятся мобцы.
                    {
                        SetEnemy(enemy, _spawnPoints[spawnPointNumber].position);
                    }
                    Debug.Log(GameDifficultySelection.gameDifficultyText + "sapwner" + _enemyTimeBetwenSpawn);
                    break;

                case "Бесконечная":
                        SetEnemy(enemy, _spawnPoints[spawnPointNumber].position);
                    Debug.Log(GameDifficultySelection.gameDifficultyText + "sapwner" + _enemyTimeBetwenSpawn);
                    break;

                 default:
                    Debug.Log(GameDifficultySelection.gameDifficultyText + "sapwner_default");
                    break;
            }
        }
    }

    private void SetEnemy(GameObject enemy, Vector3 spawnPoint)
    {
        enemy.SetActive(true);
        enemy.transform.position = spawnPoint;
    }
}

