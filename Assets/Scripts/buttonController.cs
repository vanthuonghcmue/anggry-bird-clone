using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class buttonController : MonoBehaviour
{
    public static bool GameIsPause = false;
    public GameObject pauseMenuUI;

    public void MenuButton()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("main menu");
    }

    public void RestartButton()
    {
        SceneManager.LoadScene(levelController.instance.nextLevel - 1);
    }

    public void PauseButton()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        //GameIsPause = true;
    }

    public void ResumeButton()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        //GameIsPause = false;
    }

    public void QuitButton()
    {
        Application.Quit();
    }
}

