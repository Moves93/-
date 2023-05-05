using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonPauseandSaund : MonoBehaviour
{
    [SerializeField] private Button _pauseButton;
    [SerializeField] private PauseScreen _gamePauseScreen;

    private void OnEnable()
    {
        _pauseButton.onClick.AddListener(OnPauseButtonClick);
    }

    private void OnDisable()
    {
        _pauseButton.onClick.RemoveListener(OnPauseButtonClick);
    }

    private void OnPauseButtonClick()
    {
        Time.timeScale = 0;
        _gamePauseScreen.gameObject.SetActive(true);
    }
}
