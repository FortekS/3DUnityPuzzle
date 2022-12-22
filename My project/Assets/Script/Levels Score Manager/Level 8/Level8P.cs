using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level8P : MonoBehaviour
{
    public GameObject panel;
    public ScoreManagerLevel8 schet8;
    public ControlLevel8 control8;

    public void PauseGamee()
    {
        panel.SetActive(true);
        control8.enabled = false;
        schet8.enabled = false;
        Time.timeScale = 0f;
    }

    public void continuegame()
    {
        Time.timeScale = 1f;
        control8.enabled = true;
        schet8.enabled = true;
        panel.SetActive(false);
    }
}