using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level13E : MonoBehaviour
{
    public ShowEndPanel endPanel;
    public ScoreManagerLevel13 schet13;
    public ControlLevel13 control13;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            schet13.enabled = false;
            control13.enabled = false;
            endPanel.CompleteLvl();
            Time.timeScale = 0f;

        }
    }


}