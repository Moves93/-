using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ScoreDisplay : MonoBehaviour
{
    [SerializeField] private TMP_Text _scoreDisplay;

    private void Update()
    {
        _scoreDisplay.text = "Счет: " + ((int)ObjectPool.score).ToString();
        if (ObjectPool.score >= Score.weAreInPlace)
        {
            _scoreDisplay.text = "Мы на месте";
        }
    }
}