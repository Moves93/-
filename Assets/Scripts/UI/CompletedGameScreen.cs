using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CompletedGameScreen : MonoBehaviour
{
    [SerializeField] private Button _restartButton;
    [SerializeField] private Button _quitButton;
    [SerializeField] private CompletedGameScreen _completedGameScreen;


    private void Start()
    {
        _completedGameScreen.gameObject.SetActive(false);
        Debug.Log("completedGameScreen_Start");
    }

    private void OnEnable()
    {
        _restartButton.onClick.AddListener(OnRestartButtonClick);
        _quitButton.onClick.AddListener(OnQuitButtonClick);
    }

    private void OnDisable()
    {
        _restartButton.onClick.RemoveListener(OnRestartButtonClick);
        _quitButton.onClick.RemoveListener(OnQuitButtonClick);
        _completedGameScreen.gameObject.SetActive(false);
    }

    private void OnRestartButtonClick()
    {
        ObjectPool.score = 0;
        Time.timeScale = 1f;
        SceneManager.LoadScene(1);
    }

    private void OnQuitButtonClick()
    {
        ObjectPool.score = 0;
        Time.timeScale = 1f;
        SceneManager.LoadScene(0);
    }
}
