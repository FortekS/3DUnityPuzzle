using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManagerLevel20 : MonoBehaviour
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

        if (PlayerPrefs.GetInt("scorelevel20") <= highscore)
        {
            PlayerPrefs.SetInt("scorelevel20", highscore);
        }
        HighscoreText.text = "" + PlayerPrefs.GetInt("scorelevel20").ToString();
    }
}
