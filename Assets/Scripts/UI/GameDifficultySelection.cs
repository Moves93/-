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
        if (gameDifficulty == 0) { gameDifficultyText = "������"; }
        else if (gameDifficulty == 1) { gameDifficultyText = "�������"; }
        else if (gameDifficulty == 2) { gameDifficultyText = "�������"; }
        else if (gameDifficulty == 3) { gameDifficultyText = "�����������"; }
        else { gameDifficultyText = "������"; }
    }

    private void Start()
    {
       //gameDifficultyText = "������";
    }

    private void Update()
    {
        Debug.Log(gameDifficultyText);
    }
}
