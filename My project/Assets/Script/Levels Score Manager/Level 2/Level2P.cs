using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2P : MonoBehaviour
{
    public GameObject panel;
    public ScoreManagerLevel2 schet2;
    public ControlLevel2 control2;
    public void PauseGamee()
    {
        panel.SetActive(true);
        schet2.enabled = false;
        control2.enabled = false;
        Time.timeScale = 0f;
    }

    public void continuegame()
    {
        Time.timeScale = 1f;
        schet2.enabled = true;
        control2.enabled = true;
        panel.SetActive(false);
    }
}