using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level9E : MonoBehaviour
{
    public ShowEndPanel endPanel;
    public ScoreManagerLevel9 schet9;
    public ControlLevel9 control9;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            schet9.enabled = false;
            control9.enabled = false;
            endPanel.CompleteLvl();
            Time.timeScale = 0f;

        }
    }


}