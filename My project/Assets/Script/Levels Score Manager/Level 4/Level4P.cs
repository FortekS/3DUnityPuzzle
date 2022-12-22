using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level4P : MonoBehaviour
{
    public GameObject panel;
    public ScoreManagerLevel4 schet4;
    public ControlLevel4 control4;

    public void PauseGamee()
    {
        panel.SetActive(true);
        control4.enabled = false;
        schet4.enabled = false;
        Time.timeScale = 0f;
    }

    public void continuegame()
    {
        Time.timeScale = 1f;
        control4.enabled = true;
        schet4.enabled = true;
        panel.SetActive(false);
    }
}