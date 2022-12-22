using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ControlLevel4 : MonoBehaviour
{
    public Text scoreText;
    public int score;
    public float time;
    private float timeStart;
    
    
   
    
    void Update()
    {
        time -= Time.deltaTime;
        if (time <= 0)
        {
            ScoreManagerLevel4.score += 2.1f;

            time = timeStart;
        }
    }
    
}          