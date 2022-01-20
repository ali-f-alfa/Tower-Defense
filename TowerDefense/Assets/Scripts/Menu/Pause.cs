using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour
{
    private GameObject gameMaster;
    private GameManager gameManager;

    void Start()
    {
        gameMaster = GameObject.FindWithTag("GameMaster");
        gameManager = gameMaster.GetComponent<GameManager>();

    }
    public void Continue()
    {
        gameManager.TogglePause();
    }

    public void Retry()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void Menu()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
