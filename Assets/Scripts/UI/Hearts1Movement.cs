using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.RuleTile.TilingRuleOutput;

public class Hearts1Movement : MonoBehaviour
{
    [SerializeField] private GameObject _player;

    private void Update()
    {
        transform.position = new Vector3
            (transform.position.x, 
            Mathf.Lerp(transform.position.y, _player.transform.position.y, 2f*Time.deltaTime), 
            transform.position.z);
    }
}
