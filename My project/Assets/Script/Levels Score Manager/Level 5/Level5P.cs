using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level5P : MonoBehaviour
{
    public GameObject panel;
    public ScoreManagerLevel5 schet5;
    public ControlLevel5 control5;

    public void PauseGamee()
    {
        panel.SetActive(true);
        control5.enabled = false;
        schet5.enabled = false;
        Time.timeScale = 0f;
    }

    public void continuegame()
    {
        Time.timeScale = 1f;
        control5.enabled = true;
        schet5.enabled = true;
        panel.SetActive(false);
    }
}