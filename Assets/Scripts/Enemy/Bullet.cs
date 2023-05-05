using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : Enemy
{
   
    private void Start()
    {
       
    }

    void OnEnable()
    {
       // Debug.Log("Bullet_active_OnEnable");
    }

    private void OnDisable()
    {
        Destroy(gameObject);
    }

    void Update()
    {
        transform.Translate(Vector3.left * Score.speedBullet * Time.deltaTime);
    }
}
