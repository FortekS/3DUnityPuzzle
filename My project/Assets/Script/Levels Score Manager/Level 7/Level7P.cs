using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level7P : MonoBehaviour
{
    public GameObject panel;
    public ScoreManagerLevel7 schet7;
    public ControlLevel7 control7;

    public void PauseGamee()
    {
        panel.SetActive(true);
        control7.enabled = false;
        schet7.enabled = false;
        Time.timeScale = 0f;
    }

    public void continuegame()
    {
        Time.timeScale = 1f;
        control7.enabled = true;
        schet7.enabled = true;
        panel.SetActive(false);
    }
}