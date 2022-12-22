using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gotomenu : MonoBehaviour
{
    public GameObject panel;
    public void menunormal()
    {
        SceneManager.LoadScene("Choose Levels");
        Time.timeScale = 1f;
    }
}
