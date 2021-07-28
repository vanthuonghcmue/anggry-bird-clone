using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class mapLevel : MonoBehaviour
{
    public bool isUnlock = false;
    public int level;
    public GameObject lockLevel;
    public GameObject unlockLevel;
    public Text showHightscores;
    private int hightScore;
    public GameObject start_1;
    public GameObject start_2;
    public GameObject start_3;

    public Sprite startLight_1;
    public Sprite startLight_2;
    public Sprite startLight_3;

    private void Update()
    {
        UpdateMapStatus();
        UpdateHighScore();
        changeStar();
    }

    void Start()
    {
       
    }

    private void UpdateMapStatus()
    {
        if (PlayerPrefs.HasKey("HighScores" + level.ToString()) || level == 1)
        {
            isUnlock = true;
        }
        else
        {
            isUnlock = false;
        }

        if (isUnlock)
        {
            unlockLevel.gameObject.SetActive(true);
            lockLevel.gameObject.SetActive(false);
        }
        else
        {
            unlockLevel.gameObject.SetActive(false);
            lockLevel.gameObject.SetActive(true);
        }
    }
    private void Golevel()
    {
        Debug.Log(level);
        SceneManager.LoadScene(level);
    }

    private void UpdateHighScore()
    {
        if (PlayerPrefs.HasKey("HighScores" + level.ToString()))
        {
            hightScore = PlayerPrefs.GetInt("HighScores" + level.ToString());
        }
        else
        {
            hightScore = 0;
        }
        showHightscores.text = "HighScores " + hightScore.ToString();
    }

    private void changeStar()
    {
        if (hightScore > 40)
        {
            start_1.GetComponent<Image>().sprite = startLight_1;
        }
        if (hightScore > 800)
        {
            start_2.GetComponent<Image>().sprite = startLight_2;
        }
        if (hightScore > 1000)
        {
            start_3.GetComponent<Image>().sprite = startLight_3;
        }
    }

}
