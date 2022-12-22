using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ControlLevel5 : MonoBehaviour
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
            ScoreManagerLevel5.score += 1.9f;

            time = timeStart;
        }
    }
    
}          