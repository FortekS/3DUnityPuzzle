using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level15P : MonoBehaviour
{
    public GameObject panel;
    public ScoreManagerLevel15 schet15;
    public ControlLevel15 control15;

    public void PauseGamee()
    {
        panel.SetActive(true);
        control15.enabled = false;
        schet15.enabled = false;
        Time.timeScale = 0f;
    }

    public void continuegame()
    {
        Time.timeScale = 1f;
        control15.enabled = true;
        schet15.enabled = true;
        panel.SetActive(false);
    }
}