using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;
using static UnityEngine.GraphicsBuffer;

public class Player : MonoBehaviour
{
    [SerializeField] private int _health;
    [SerializeField] private GameObject[] _heart;
    [SerializeField] private GameObject _freePlace1;
    [SerializeField] private GameObject _freePlace2;
    [SerializeField] private GameObject _freePlace3;
    [SerializeField] private GameObject _freePlace4;

    public event UnityAction<int> HealthChanged;
    public event UnityAction Died;

    private void Start()
    {
        HealthChanged?.Invoke(_health);
        _freePlace1.SetActive(false);
        _freePlace2.SetActive(false);
        _freePlace3.SetActive(false);
        _freePlace4.SetActive(true);
    }

    public void ApplyDamage(int damage)
    {
        
        _health -= damage;
        HealthChanged?.Invoke(_health);
        if (_health > 3) _health = 3;

        switch (_health)
        {
            case 0: 
                Die();
                ObjectPool.score = 0;
                break;
            case 1:
                _heart[1].gameObject.SetActive(false);
                _heart[0].gameObject.SetActive(false);
                _freePlace1.SetActive(false);
                _freePlace2.SetActive(false);
                _freePlace3.SetActive(true);
                _freePlace4.SetActive(false);
                break;
            case 2: 
                _heart[1].gameObject.SetActive(false);
                _heart[0].gameObject.SetActive(true);
                _freePlace1.SetActive(false);
                _freePlace2.SetActive(true);
                _freePlace3.SetActive(false);
                _freePlace4.SetActive(false);
                break;
            case 3:
                _heart[1].gameObject.SetActive(true);
                _heart[0].gameObject.SetActive(true);
                _freePlace1.SetActive(true);
                _freePlace2.SetActive(false);
                _freePlace3.SetActive(false);
                _freePlace4.SetActive(false);
                break;
            default: 
                break;
        }
    }

    public void Die()
    {
        Died?.Invoke();
    }
   
}

    
