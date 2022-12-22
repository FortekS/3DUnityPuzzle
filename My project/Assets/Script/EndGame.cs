using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    public void EndGames()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(22);
    }
    public void GoToMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(1);
    }
    public void GoToMainMenu()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }

}
