using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameOverMenu : MonoBehaviour
{
    [SerializeField] private TMP_Text timeText;

    void Start()
    {
        float timerValue = PlayerStatsManager.playerTimer;
        TimeSpan ts = TimeSpan.FromSeconds(timerValue);
        timeText.text = "Your time: " + ts.ToString(@"mm\:ss\:fff");
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene("GameScene");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
