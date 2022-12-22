using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level19P : MonoBehaviour
{
    public GameObject panel;
    public ScoreManagerLevel19 schet19;
    public ControlLevel19 control19;

    public void PauseGamee()
    {
        panel.SetActive(true);
        control19.enabled = false;
        schet19.enabled = false;
        Time.timeScale = 0f;
    }

    public void continuegame()
    {
        Time.timeScale = 1f;
        control19.enabled = true;
        schet19.enabled = true;
        panel.SetActive(false);
    }
}