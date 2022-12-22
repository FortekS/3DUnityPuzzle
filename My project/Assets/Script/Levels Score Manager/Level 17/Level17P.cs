using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level17P : MonoBehaviour
{
    public GameObject panel;
    public ScoreManagerLevel17 schet17;
    public ControlLevel17 control17;

    public void PauseGamee()
    {
        panel.SetActive(true);
        control17.enabled = false;
        schet17.enabled = false;
        Time.timeScale = 0f;
    }

    public void continuegame()
    {
        Time.timeScale = 1f;
        control17.enabled = true;
        schet17.enabled = true;
        panel.SetActive(false);
    }
}