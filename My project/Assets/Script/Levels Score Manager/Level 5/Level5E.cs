using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level5E : MonoBehaviour
{
    public ShowEndPanel endPanel;
    public ScoreManagerLevel5 schet5;
    public ControlLevel5 control5;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            schet5.enabled = false;
            control5.enabled = false;
            endPanel.CompleteLvl();
            Time.timeScale = 0f;

        }
    }


}