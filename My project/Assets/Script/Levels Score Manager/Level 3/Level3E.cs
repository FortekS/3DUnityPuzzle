using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level3E : MonoBehaviour
{
    public ShowEndPanel endPanel;
    public ScoreManagerLevel3 schet3;
    public ControlLevel3 control3;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            control3.enabled = false;
            schet3.enabled = false;
            endPanel.CompleteLvl();
            Time.timeScale = 0f;

        }
    }


}