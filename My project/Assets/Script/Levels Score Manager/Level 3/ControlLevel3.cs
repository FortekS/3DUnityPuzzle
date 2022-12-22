using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ControlLevel3 : MonoBehaviour
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
            ScoreManagerLevel3.score += 1.1f;

            time = timeStart;
        }
    }
    
}          