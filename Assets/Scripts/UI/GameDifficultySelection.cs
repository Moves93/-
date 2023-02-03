using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameDifficultySelection : MonoBehaviour
{
    //public TMP_Text Text;
    public TMP_Dropdown Dropdown;
    public string gameDifficultyText;

    public void DifficultySelection(int gameDifficulty)
    {
        if (gameDifficulty == 0) { gameDifficultyText = "Легкая"; }
        else if (gameDifficulty == 1) { gameDifficultyText = "Средняя"; }
        else if (gameDifficulty == 2) { gameDifficultyText = "Сложная"; }
        else if (gameDifficulty == 3) { gameDifficultyText = "Бесконечная"; }
        else { gameDifficultyText = "Легкая"; }
    }

    private void Start()
    {
       //gameDifficultyText = "Легкая";
    }

    private void Update()
    {
        Debug.Log(gameDifficultyText);
    }
}
