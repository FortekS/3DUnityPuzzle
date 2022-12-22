using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level18E : MonoBehaviour
{
    public ShowEndPanel endPanel;
    public ScoreManagerLevel18 schet18;
    public ControlLevel18 control18;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            schet18.enabled = false;
            control18.enabled = false;
            endPanel.CompleteLvl();
            Time.timeScale = 0f;

        }
    }


}