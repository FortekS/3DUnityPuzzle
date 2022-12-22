using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level4E : MonoBehaviour
{
    public ShowEndPanel endPanel;
    public ScoreManagerLevel4 schet4;
    public ControlLevel4 control4;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            schet4.enabled = false;
            control4.enabled = false;
            endPanel.CompleteLvl();
            Time.timeScale = 0f;

        }
    }


}