using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOverScreen : MonoBehaviour
{
    [SerializeField] private Button _restartButton;
    [SerializeField] private Button _quitButton;
    [SerializeField] private Player _player;
    [SerializeField] private GameOverScreen _gameOverScreen;

    private void OnEnable()
    {
        _player.Died += OnDied;
        _restartButton.onClick.AddListener(OnRestartButtonClick);
        _quitButton.onClick.AddListener(OnQuitButtonClick);
    }

    private void OnDisable()
    {
        _player.Died -= OnDied;
        _restartButton.onClick.RemoveListener(OnRestartButtonClick);
        _quitButton.onClick.RemoveListener(OnQuitButtonClick);
    }

    private void Start()
    {
        _gameOverScreen.gameObject.SetActive(false);
    }

    private void OnDied()
    {
        _gameOverScreen.gameObject.SetActive(true);
        Time.timeScale = 0;
    }

    private void OnRestartButtonClick()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }

    private void OnQuitButtonClick()
    {
        Application.Quit();
        Debug.Log("Quit game");
    }
}
