using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level10P : MonoBehaviour
{
    public GameObject panel;
    public ScoreManagerLevel10 schet10;
    public ControlLevel10 control10;

    public void PauseGamee()
    {
        panel.SetActive(true);
        control10.enabled = false;
        schet10.enabled = false;
        Time.timeScale = 0f;
    }

    public void continuegame()
    {
        Time.timeScale = 1f;
        control10.enabled = true;
        schet10.enabled = true;
        panel.SetActive(false);
    }
}