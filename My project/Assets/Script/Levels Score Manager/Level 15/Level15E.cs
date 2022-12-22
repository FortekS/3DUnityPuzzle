using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level15E : MonoBehaviour
{
    public ShowEndPanel endPanel;
    public ScoreManagerLevel15 schet15;
    public ControlLevel15 control15;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            schet15.enabled = false;
            control15.enabled = false;
            endPanel.CompleteLvl();
            Time.timeScale = 0f;

        }
    }


}