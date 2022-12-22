using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level8E : MonoBehaviour
{
    public ShowEndPanel endPanel;
    public ScoreManagerLevel8 schet8;
    public ControlLevel8 control8;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            schet8.enabled = false;
            control8.enabled = false;
            endPanel.CompleteLvl();
            Time.timeScale = 0f;

        }
    }


}