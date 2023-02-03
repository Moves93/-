using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonPlay : MonoBehaviour
{
    public GameDifficultySelection gameDifficultySelection;

    //[SerializeField] public Scene _easy;

    public void OnButtonPlayClick()
    {
        if (gameDifficultySelection.gameDifficultyText == "Легкая")
        {
            SceneManager.LoadScene("SampleScene");
        }
        else
        {
            Debug.Log("no scene");
        }
        
    }
}
