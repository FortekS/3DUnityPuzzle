using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManagerLevel1 : MonoBehaviour
{
    [SerializeField] Text HighscoreText;
    [SerializeField] Text ScoreText;

    public static float score;
    int highscore;
        void Start()
    {
        score = 0;
    }

    void Update()
    {
        highscore = (int)score;
        ScoreText.text = "" + highscore.ToString();

        if (PlayerPrefs.GetInt("scorelevel1") <= highscore)
        {
            PlayerPrefs.SetInt("scorelevel1", highscore);
        }
        HighscoreText.text = "" + PlayerPrefs.GetInt("scorelevel1").ToString();
    }
}
