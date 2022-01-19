using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static bool IsGameOver;
    public GameObject gameOverUI;

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
    }

    public void EndGame()
    {
        IsGameOver = true;
        gameOverUI.SetActive(true);
        Time.timeScale = 0f;
    }

}
