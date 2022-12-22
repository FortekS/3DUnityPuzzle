using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level18P : MonoBehaviour
{
    public GameObject panel;
    public ScoreManagerLevel18 schet18;
    public ControlLevel18 control18;

    public void PauseGamee()
    {
        panel.SetActive(true);
        control18.enabled = false;
        schet18.enabled = false;
        Time.timeScale = 0f;
    }

    public void continuegame()
    {
        Time.timeScale = 1f;
        control18.enabled = true;
        schet18.enabled = true;
        panel.SetActive(false);
    }
}