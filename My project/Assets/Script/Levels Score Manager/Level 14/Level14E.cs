using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level14E : MonoBehaviour
{
    public ShowEndPanel endPanel;
    public ScoreManagerLevel14 schet14;
    public ControlLevel14 control14;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            schet14.enabled = false;
            control14.enabled = false;
            endPanel.CompleteLvl();
            Time.timeScale = 0f;

        }
    }


}