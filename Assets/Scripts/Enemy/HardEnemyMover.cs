using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HardEnemyMover : MonoBehaviour
{
    [SerializeField] private float _stepSize;
    [SerializeField] private float _maxHeight;
    [SerializeField] private float _minHeight;
    private Vector3 _targetPosition;
    private int _speed;
    private HardEnemyMover _mover;
    private int x;

    private void Start()
    {
        _targetPosition = transform.position;
        _speed = Score.speedMobs;
        _mover = GetComponent<HardEnemyMover>();
        StartCoroutine(HardEnemyStepbyStep());
        StopCoroutine(HardEnemyStepbyStep());
    }

    private void Update()
    {
        if (transform.position != _targetPosition)
            transform.position = Vector3.MoveTowards(transform.position, _targetPosition, _speed * Time.deltaTime);
    }
    private void SetNextPosition(float stepsize)
    {
        _targetPosition = new Vector2(_targetPosition.x, _targetPosition.y + stepsize);
    }

    public void TryMovesUpEnemy()
    {
        if (_targetPosition.y < _maxHeight)
            SetNextPosition(_stepSize);
    }

    public void TryMovesDownEnemy()
    {
        if (_targetPosition.y > _minHeight)
            SetNextPosition(-_stepSize);
    }

    private IEnumerator HardEnemyStepbyStep()
    {
        x = Random.Range(1, 2);
        var waitForOneSeconds = new WaitForSeconds(1f);
        yield return waitForOneSeconds;
        if (ObjectPool.score == 21)
        {
            if (_targetPosition.y == 2)
            {
                _mover.TryMovesDownEnemy();
                Debug.Log("траймув даун при у = 2");
            }
            else if (_targetPosition.y == -4)
            {
                _mover.TryMovesUpEnemy();
                Debug.Log("траймув ап при у = -4");
            }
            else
            {
                if (x == 1)
                {
                    _mover.TryMovesDownEnemy();
                    Debug.Log("траймув даун при х = 1");
                }
                else
                {
                    _mover.TryMovesUpEnemy();
                    Debug.Log("траймув ап при х = 2");
                }
            }
        }
    }



}
