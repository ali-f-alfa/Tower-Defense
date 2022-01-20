using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static bool IsGameOver;
    public GameObject gameOverUI;
    public GameObject pausedMenuUI;

    void Start()
    {
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
