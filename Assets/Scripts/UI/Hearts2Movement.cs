using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class Hearts2Movement : MonoBehaviour
{
    [SerializeField] private GameObject _heart1;

    private void Update()
    {
        transform.position = new Vector3
            (transform.position.x, 
            Mathf.Lerp(transform.position.y, _heart1.transform.position.y, 2f*Time.deltaTime), 
            transform.position.z);
    }
}
