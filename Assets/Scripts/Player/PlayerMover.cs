using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMover : MonoBehaviour
{
   [SerializeField] private float _speed;
   [SerializeField] private float _stepSize;
   [SerializeField] private float _maxHeight;
   [SerializeField] private float _minHeight;

    private Vector3 _targetPosition;

    private void Start()
    {
        _targetPosition = transform.position;
    }

    private void Update()
    {
        if(transform.position != _targetPosition && ObjectPool.score <= Score.playerMoverStop)
            transform.position = Vector3.MoveTowards(transform.position, _targetPosition, _speed*Time.deltaTime);
    }

    public void TryMovesUp()
    {
        if(_targetPosition.y < _maxHeight)
        SetNextPosition(_stepSize);
    }

    public void TryMovesDown()
    {
        if (_targetPosition.y > _minHeight)
            SetNextPosition(-_stepSize);
    }

    private void SetNextPosition(float stepsize)
    {
        _targetPosition = new Vector2(_targetPosition.x, _targetPosition.y + stepsize);
    }
}
