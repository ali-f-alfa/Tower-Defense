using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string LevelToLoad;

    void Start()
    {
        LevelToLoad = "Level1";
        Time.timeScale = 1f;
    }

    public void Play()
    {
        SceneManager.LoadScene(LevelToLoad);
    }

    public void Quit()
    {
        Debug.Log("Quit");
        Application.Quit();
    }
}
