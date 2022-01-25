using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static bool IsGameOver;
    public static bool IsGameComplete;

    public GameObject gameOverUI;
    public GameObject pausedMenuUI;
    public GameObject CompleteLevelUI;

    void Start()
    {
        IsGameComplete = false;
        IsGameOver = false;
        Time.timeScale = 1f;
    }

    void Update()
    {
        if (IsGameOver)
        {
            EndGame();
            return;
        }
        if (IsGameComplete)
        {
            WinGame();
            return;
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            TogglePause();
        }
    }

    public void EndGame()
    {
        IsGameOver = true;
        gameOverUI.SetActive(true);
        Time.timeScale = 0f;
    }

    public void WinGame()
    {
        IsGameComplete = true;
        CompleteLevelUI.SetActive(true);
        Time.timeScale = 0f;
    }

    public void TogglePause()
    {
        pausedMenuUI.SetActive(!pausedMenuUI.activeSelf);

        if (pausedMenuUI.activeSelf)
        {
            Time.timeScale = 0f;
        }
        else
        {
            Time.timeScale = 1f;
        }
    }
}
