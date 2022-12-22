using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level20E : MonoBehaviour
{
    public ShowEndPanel endPanel;
    public ScoreManagerLevel20 schet20;
    public ControlLevel20 control20;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            control20.enabled = false;
            schet20.enabled = false;
            endPanel.CompleteLvl();
            Time.timeScale = 0f;

        }
    }


}