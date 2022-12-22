using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level3P : MonoBehaviour
{
    public GameObject panel;
    public ScoreManagerLevel3 schet3;
    public ControlLevel3 control3;


    public void PauseGamee()
    {
        panel.SetActive(true);
        control3.enabled = false;
        schet3.enabled = false;
        Time.timeScale = 0f;
    }

    public void continuegame()
    {
        Time.timeScale = 1f;
        control3.enabled = true;
        schet3.enabled = true;
        panel.SetActive(false);
    }
}