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

    public event UnityAction<int> HealthChanged;
    public event UnityAction Died;


    private void Start()
    {
        HealthChanged?.Invoke(_health);
    }

    public void ApplyDamage(int damage)
    {
        _health -= damage;
        HealthChanged?.Invoke(_health);
        switch (_health)
        {
            case 0: 
                Die(); 
                break;
            case 1:
                _heart[1].gameObject.SetActive(false);
                _heart[0].gameObject.SetActive(false); 
                break;
            case 2: 
                _heart[1].gameObject.SetActive(false);
                _heart[0].gameObject.SetActive(true);
                break;
            case 3:
                _heart[1].gameObject.SetActive(true);
                _heart[0].gameObject.SetActive(true);
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
    
