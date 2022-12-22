using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level11P : MonoBehaviour
{
    public GameObject panel;
    public ScoreManagerLevel11 schet11;
    public ControlLevel11 control11;

    public void PauseGamee()
    {
        panel.SetActive(true);
        control11.enabled = false;
        schet11.enabled = false;
        Time.timeScale = 0f;
    }

    public void continuegame()
    {
        Time.timeScale = 1f;
        control11.enabled = true;
        schet11.enabled = true;
        panel.SetActive(false);
    }
}