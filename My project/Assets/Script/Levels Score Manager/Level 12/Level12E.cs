using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level12E : MonoBehaviour
{
    public ShowEndPanel endPanel;
    public ScoreManagerLevel12 schet12;
    public ControlLevel12 control12;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            schet12.enabled = false;
            control12.enabled = false;
            endPanel.CompleteLvl();
            Time.timeScale = 0f;

        }
    }


}