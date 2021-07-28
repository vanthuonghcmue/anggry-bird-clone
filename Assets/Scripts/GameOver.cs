using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    public Text show_scores;
    public Text show_Hight_scores;

    // Start is called before the first frame update
    void Start()
    {
        show_scores.text = "Scores: " + Scores.instance.scores.ToString();
        show_Hight_scores.text = "Hight Score: " + Scores.instance.hightScore.ToString();
    }

    public void RestartButton()
    {
        SceneManager.LoadScene(levelController.instance.nextLevel - 1);
    }

    public void NextLevelButton()
    {
        SceneManager.LoadScene(levelController.instance.nextLevel);
    }

    public void ExitButton()
    {
        SceneManager.LoadScene ("main menu");
    }


}
