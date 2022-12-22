using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level9P : MonoBehaviour
{
    public GameObject panel;
    public ScoreManagerLevel9 schet9;
    public ControlLevel9 control9;

    public void PauseGamee()
    {
        panel.SetActive(true);
        control9.enabled = false;
        schet9.enabled = false;
        Time.timeScale = 0f;
    }

    public void continuegame()
    {
        Time.timeScale = 1f;
        control9.enabled = true;
        schet9.enabled = true;
        panel.SetActive(false);
    }
}