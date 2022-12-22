using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level20P : MonoBehaviour
{
    public GameObject panel;
    public ScoreManagerLevel20 schet20;
    public ControlLevel20 control20;

    public void PauseGamee()
    {
        panel.SetActive(true);
        control20.enabled = false;
        schet20.enabled = false;
        Time.timeScale = 0f;
    }

    public void continuegame()
    {
        Time.timeScale = 1f;
        control20.enabled = true;
        schet20.enabled = true;
        panel.SetActive(false);
    }
}