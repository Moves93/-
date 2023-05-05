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
        Initialize(_enemyPrefabs);
    }

    private void OnEnable()
    {
        switch (GameDifficultySelection.gameDifficultyText)
        {
            case "������":
                _enemyTimeBetwenSpawn = 1.5f;
                break;
            case "�������":
                _enemyTimeBetwenSpawn = 1.2f;
                break;
            case "�������":
                _enemyTimeBetwenSpawn = 1.0f;
                break;
            case "�����������":
                _enemyTimeBetwenSpawn = 1.0f;
                break;
            default:
                break;
        }
    }

    private void Update()
    {
        _spawnTime += Time.deltaTime;

        
        //ObjectPool.score= 1 + 1 * (int)Time.deltaTime;
        if (_spawnTime >= _enemyTimeBetwenSpawn)
        {


            if(TryGetObject(out GameObject enemy))
            _spawnTime = 0;
            
            int spawnPointNumber = Random.Range(0, _spawnPoints.Length);

            switch (GameDifficultySelection.gameDifficultyText)
            {
                case "������":
                    if (ObjectPool.score <= Score.spawnerActiveEasy)//�� ������ ����� ��������� �����.
                    {
                        SetEnemy(enemy, _spawnPoints[spawnPointNumber].position);
                    }
                    break;

                case "�������":
                    if (ObjectPool.score <= Score.spawnerActiveMedium)//�� ������ ����� ��������� �����.
                    {
                        SetEnemy(enemy, _spawnPoints[spawnPointNumber].position);
                    }
                    break;

                case "�������":
                    if (ObjectPool.score <= Score.spawnerActiveHard)//�� ������ ����� ��������� �����.
                    {
                        SetEnemy(enemy, _spawnPoints[spawnPointNumber].position);
                    }
                    break;

                case "�����������":
                        SetEnemy(enemy, _spawnPoints[spawnPointNumber].position);
                    break;

                 default:
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

