using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level10E : MonoBehaviour
{
    public ShowEndPanel endPanel;
    public ScoreManagerLevel10 schet10;
    public ControlLevel10 control10;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            schet10.enabled = false;
            control10.enabled = false;
            endPanel.CompleteLvl();
            Time.timeScale = 0f;

        }
    }


}