using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause123 : MonoBehaviour
{
    public GameObject panel;
    public ScoreManagerLevel1 schet;
    public Control controllvl1;

    public void PauseGamee()
    {
        panel.SetActive(true);
        controllvl1.enabled = false;
        schet.enabled = false;
        Time.timeScale = 0f;
    }

    public void continuegame()
    {
        Time.timeScale = 1f;
        controllvl1.enabled = true;
        schet.enabled = true;
        panel.SetActive(false);
    }
}