using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class ScoreDisplay : MonoBehaviour
{

    [SerializeField] private TMP_Text _scoreDisplay;

    private void Update()
    {
        _scoreDisplay.text = ObjectPool.score.ToString()+"%";
        if (ObjectPool.score >= 5)
        {
            _scoreDisplay.text = "Мы на месте";
        }


    }
}