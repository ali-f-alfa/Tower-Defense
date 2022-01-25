using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public int NumberOfLevels;

    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Menu()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Continue()
    {
        int levelNumber = SceneManager.GetActiveScene().buildIndex - 1;
        Debug.Log("level number: " + levelNumber);

        if (levelNumber >= NumberOfLevels)
            return;

        Debug.Log("build index: " + SceneManager.GetActiveScene().buildIndex);

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
