using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level2E : MonoBehaviour
{
    public ShowEndPanel endPanel;
    public ScoreManagerLevel2 schet2;
    public ControlLevel2 control2;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            schet2.enabled = false;
            control2.enabled = false;
            endPanel.CompleteLvl();
            Time.timeScale = 0f;

        }
    }


}