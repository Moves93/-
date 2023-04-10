using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseScreen : MonoBehaviour
{
    [SerializeField] private Button _restartButton;
    [SerializeField] private Button _quitButton;
    [SerializeField] private Button _continueButton;
    [SerializeField] private Button _soundButton;
    [SerializeField] private PauseScreen _gamePauseScreen;

    private void Start()
    {
        _gamePauseScreen.gameObject.SetActive(false);
    }

    private void OnEnable()
    {
        _restartButton.onClick.AddListener(OnRestartButtonClick);
        _quitButton.onClick.AddListener(OnQuitButtonClick);
        _continueButton.onClick.AddListener(OnContinueButtonClick);
        _soundButton.onClick.AddListener(OnSoundButtonClick);
    }

    private void OnDisable()
    {
        _restartButton.onClick.RemoveListener(OnRestartButtonClick);
        _quitButton.onClick.RemoveListener(OnQuitButtonClick);
        _continueButton.onClick.RemoveListener(OnContinueButtonClick);
        _soundButton.onClick.RemoveListener(OnSoundButtonClick);
    }

    private void OnRestartButtonClick()
    {
        Time.timeScale = 1f;
        ObjectPool.score = 0;
        SceneManager.LoadScene(1);
    }

    private void OnQuitButtonClick()
    {
        ObjectPool.score = 0;
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }

    private void OnContinueButtonClick()
    {
        _gamePauseScreen.gameObject.SetActive(false);
        Time.timeScale = 1f;
    }
    private void OnSoundButtonClick()
    {

    }



}
