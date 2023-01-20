using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseMover : MonoBehaviour
{
    private float _speed =5;

    private void Update()
    {
        if (transform.position.x >= 12) 
        {
            transform.Translate(Vector3.left * _speed * Time.deltaTime);
        } 
    }
}
