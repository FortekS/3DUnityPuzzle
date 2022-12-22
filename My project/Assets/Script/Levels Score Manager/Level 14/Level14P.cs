using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level14P : MonoBehaviour
{
    public GameObject panel;
    public ScoreManagerLevel14 schet14;
    public ControlLevel14 control14;


    public void PauseGamee()
    {
        panel.SetActive(true);
        control14.enabled = false;
        schet14.enabled = false;
        Time.timeScale = 0f;
    }

    public void continuegame()
    {
        Time.timeScale = 1f;
        control14.enabled = true;
        schet14.enabled = true;
        panel.SetActive(false);
    }
}