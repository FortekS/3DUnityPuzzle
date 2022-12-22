using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class ShowEndPanel : MonoBehaviour
{

    public GameObject CompleteLevelUI;

    private void Awake()
    {
        CompleteLevelUI.SetActive(false);
    }
    public void CompleteLvl()
    {
        CompleteLevelUI.SetActive(true);
    }

    public void Restart()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);
    }

    public void ReturnToMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }

    public void GoTolevel()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex + 1);
    }
}