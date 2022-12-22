using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level12P : MonoBehaviour
{
    public GameObject panel;
    public ScoreManagerLevel12 schet12;
    public ControlLevel12 control12;

    public void PauseGamee()
    {
        panel.SetActive(true);
        control12.enabled = false;
        schet12.enabled = false;
        Time.timeScale = 0f;
    }

    public void continuegame()
    {
        Time.timeScale = 1f;
        control12.enabled = true;
        schet12.enabled = true;
        panel.SetActive(false);
    }
}