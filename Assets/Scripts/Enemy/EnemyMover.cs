using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMover : MonoBehaviour
{
    private int _speed;

    private void Start()
    {
        _speed = Score.speedMobs;
    }

    private void Update()
    {
        transform.Translate(Vector3.left * _speed * Time.deltaTime);
    }
}
