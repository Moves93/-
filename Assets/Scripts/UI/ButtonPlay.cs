using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonPlay : MonoBehaviour
{
    public void OnButtonPlayClick()
    {
        SceneManager.LoadScene("GameLevel");
    }
}
