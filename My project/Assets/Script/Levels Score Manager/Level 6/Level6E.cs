using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level6E : MonoBehaviour
{
    public ShowEndPanel endPanel;
    public ScoreManagerLevel6 schet6;
    public ControlLevel6 control6;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            schet6.enabled = false;
            control6.enabled = false;
            endPanel.CompleteLvl();
            Time.timeScale = 0f;

        }
    }


}