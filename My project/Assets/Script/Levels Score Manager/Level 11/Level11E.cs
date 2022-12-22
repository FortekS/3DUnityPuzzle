using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Level11E : MonoBehaviour
{
    public ShowEndPanel endPanel;
    public ScoreManagerLevel11 schet11;
    public ControlLevel11 control11;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            schet11.enabled = false;
            control11.enabled = false;
            endPanel.CompleteLvl();
            Time.timeScale = 0f;

        }
    }


}