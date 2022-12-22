using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level6P : MonoBehaviour
{
    public GameObject panel;
    public ScoreManagerLevel6 schet6;
    public ControlLevel6 control6;

    public void PauseGamee()
    {
        panel.SetActive(true);
        control6.enabled = false;
        schet6.enabled = false;
        Time.timeScale = 0f;
    }

    public void continuegame()
    {
        Time.timeScale = 1f;
        control6.enabled = true;
        schet6.enabled = true;
        panel.SetActive(false);
    }
}