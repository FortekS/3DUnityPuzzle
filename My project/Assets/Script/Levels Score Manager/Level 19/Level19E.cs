using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level19E : MonoBehaviour
{
    public ShowEndPanel endPanel;
    public ScoreManagerLevel19 schet19;
    public ControlLevel19 control19;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            control19.enabled = false;
            schet19.enabled = false;
            endPanel.CompleteLvl();
            Time.timeScale = 0f;

        }
    }


}