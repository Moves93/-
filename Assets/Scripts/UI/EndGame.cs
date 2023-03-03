using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private Transform _spawnPointBase;
    [SerializeField] private GameObject _base;
    [SerializeField] private GameObject _spawner;
    [SerializeField] private GameObject _heart1;
    [SerializeField] private GameObject _heart2;
    [SerializeField] private GameObject _spawnPoint1;
    [SerializeField] private GameObject _spawnPoint2;
    [SerializeField] private GameObject _spawnPoint3;

    private float speed = 1f;



    private void Start()
    {
        _base.SetActive(false);
    }

    private void Update()
    {
        if (ObjectPool.score == Score.baseActivetrue)
        {
            _base.SetActive(true);
        } 
        else if (ObjectPool.score >= Score.driveToBase)
        {
           _player.transform.position = new Vector3 (
            Mathf.Lerp(_player.transform.position.x, _base.transform.position.x + 5, speed * Time.deltaTime),
            Mathf.Lerp(_player.transform.position.y, _base.transform.position.y, speed * Time.deltaTime),
            transform.position.z);

            _heart1.transform.position = new Vector3(
            Mathf.Lerp(_heart1.transform.position.x, _base.transform.position.x + 2, speed * Time.deltaTime),
            Mathf.Lerp(_heart1.transform.position.y, _base.transform.position.y, speed * Time.deltaTime),
            transform.position.z);

            _heart2.transform.position = new Vector3(
            Mathf.Lerp(_heart2.transform.position.x, _base.transform.position.x + 2, speed * Time.deltaTime),
            Mathf.Lerp(_heart2.transform.position.y, _base.transform.position.y, speed * Time.deltaTime),
            transform.position.z);
        }
        else if (ObjectPool.score == Score.stopTime)
        {
            Time.timeScale = 0;
        }
    }
}
