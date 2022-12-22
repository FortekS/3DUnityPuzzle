using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level17E : MonoBehaviour
{
    public ShowEndPanel endPanel;
    public ScoreManagerLevel17 schet17;
    public ControlLevel17 control17;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            schet17.enabled = false;
            control17.enabled = false;
            endPanel.CompleteLvl();
            Time.timeScale = 0f;

        }
    }


}