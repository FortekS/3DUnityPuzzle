using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level16E : MonoBehaviour
{
    public ShowEndPanel endPanel;
    public ScoreManagerLevel16 schet16;
    public ControlLevel16 control16;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            schet16.enabled = false;
            control16.enabled = false;
            endPanel.CompleteLvl();
            Time.timeScale = 0f;

        }
    }


}