using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndTrigger : MonoBehaviour
{
    public ShowEndPanel endPanel;
    public ScoreManagerLevel1 schet;
    public Control controllvl1;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            schet.enabled = false;
            controllvl1.enabled = false;
            endPanel.CompleteLvl();
            Time.timeScale = 0f;

        }
    }


}