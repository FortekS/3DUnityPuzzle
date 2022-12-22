using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManagerLevel2 : MonoBehaviour
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

        if (PlayerPrefs.GetInt("scorelevel2") <= highscore)
        {
            PlayerPrefs.SetInt("scorelevel2", highscore);
        }
        HighscoreText.text = "" + PlayerPrefs.GetInt("scorelevel2").ToString();
    }
}
