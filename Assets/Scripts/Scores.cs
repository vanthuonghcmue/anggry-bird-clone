using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Scores : MonoBehaviour
{
    Text show_scores;

    public static Scores instance { get; private set; }
    public int scores, hightScore ;
    public Text hightScoresText;

    private void Awake()
    {
        instance = this;
     
    }

    // Start is called before the first frame update
    void Start()
    {
        show_scores = GetComponent<Text>();
        scores = 0;

        if (PlayerPrefs.HasKey("HighScores" + (levelController.instance.nextLevel - 1).ToString()))
        {
            hightScore = PlayerPrefs.GetInt("HighScores" + (levelController.instance.nextLevel - 1).ToString());
        }
        else
        {   
            hightScore = 0;
        }
    }

    // Update is called once per frame
    void Update()
    {
        show_scores.text = "Scrores: " + scores.ToString();
        hightScoresText.text = "HighScores: " + hightScore.ToString();
        UpdataHightScore(levelController.instance.nextLevel - 1);
    }

    public void UpdataHightScore(int level)
    {
        if ( scores > hightScore)
        {
            hightScore = scores;
            PlayerPrefs.SetInt("HighScores"+ level.ToString(), hightScore);
        }
    }
}
