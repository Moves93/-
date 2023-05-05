using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class HardEnemyMover : MonoBehaviour
{
    [SerializeField] private float _stepSize;
    [SerializeField] private float _maxHeight;
    [SerializeField] private float _minHeight;
    [SerializeField] private float _timeStep;
    [SerializeField] private GameObject _bullet;
    private Vector3 _targetPosition;
    private float _speed;
    private int x;
    private float score;
    private bool canmov;



    private void OnEnable()
    {
        score = ObjectPool.score;
        //StartCoroutine(HardEnemyStepbyStep());
        //StopCoroutine(HardEnemyStepbyStep());
        canmov = true;
        x = Random.Range(1, 3);
        //Debug.Log(x);

    }
    private void OnDisable()
    {
        //canmov = false;
    }

    private void Start()
    {
        _targetPosition = transform.position;
        _speed = Score.speedMobs;
    }

    private void Update()
    {
        if (canmov == true) 
        { 
            HardEnemyStepbyStep();
        }
        
        if (transform.position.y == _targetPosition.y) 
        {
          transform.Translate(Vector3.left * _speed * Time.deltaTime);
        }
        else
        {
           transform.position = new Vector3(
                transform.position.x,
                Mathf.Lerp(transform.position.y, _targetPosition.y, _speed * Time.deltaTime),   
                transform.position.z);

           transform.Translate(Vector3.left * _speed * Time.deltaTime);
        }

    }
    private void SetNextPosition(float stepsize)
    {
        _targetPosition = new Vector2(
            transform.position.x, 
            _targetPosition.y + stepsize); 
    }

    private void TryMovesUpEnemy()
    {
        if (_targetPosition.y < _maxHeight) 
        { 
            SetNextPosition(_stepSize); 
        }
    }

    private void TryMovesDownEnemy()
    {
        if (_targetPosition.y > _minHeight) 
        { 
            SetNextPosition(-_stepSize); 
        }
    }

    private void HardEnemyStepbyStep()  //IEnumerator
    {
        
        //var waitForOneSeconds = new WaitForSeconds(2f);
        //yield return waitForOneSeconds;
        if (ObjectPool.score >= score + _timeStep) //ObjectPool.score != score
        {
            if (_timeStep == 2)
            {
                Instantiate(_bullet, transform.position, transform.rotation);
            }

            if (_targetPosition.y == 2)
                {
                TryMovesDownEnemy();
                }
            else if (_targetPosition.y == -4)
                {
                TryMovesUpEnemy();
                }
           else if (_targetPosition.y == -1)
            {
                if (x == 2)
                {
                    TryMovesDownEnemy();
                }
                else
                {
                    TryMovesUpEnemy();
                }
            }
            else
            {
                Debug.Log("Error_TryMoves");
            }
               
                
            canmov = false;
        }
    }



}
