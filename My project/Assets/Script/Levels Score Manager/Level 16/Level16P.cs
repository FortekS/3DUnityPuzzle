using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level16P : MonoBehaviour
{
    public GameObject panel;
    public ScoreManagerLevel16 schet16;
    public ControlLevel16 control16;

    public void PauseGamee()
    {
        panel.SetActive(true);
        control16.enabled = false;
        schet16.enabled = false;
        Time.timeScale = 0f;
    }

    public void continuegame()
    {
        Time.timeScale = 1f;
        control16.enabled = true;
        schet16.enabled = true;
        panel.SetActive(false);
    }
}