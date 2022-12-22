using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level13P : MonoBehaviour
{
    public GameObject panel;
    public ScoreManagerLevel13 schet13;
    public ControlLevel13 control13;

    public void PauseGamee()
    {
        panel.SetActive(true);
        control13.enabled = false;
        schet13.enabled = false;
        Time.timeScale = 0f;
    }

    public void continuegame()
    {
        Time.timeScale = 1f;
        control13.enabled = true;
        schet13.enabled = true;
        panel.SetActive(false);
    }
}