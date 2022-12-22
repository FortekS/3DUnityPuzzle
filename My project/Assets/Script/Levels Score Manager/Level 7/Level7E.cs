using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level7E : MonoBehaviour
{
    public ShowEndPanel endPanel;
    public ScoreManagerLevel7 schet7;
    public ControlLevel7 control7;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            schet7.enabled = false;
            control7.enabled = false;
            endPanel.CompleteLvl();
            Time.timeScale = 0f;

        }
    }


}