using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIMANAGER : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("GamePlay");
    }



    public void Restart()
    {
        SceneManager.LoadScene("GamePlay");
    }



    public void QuitGame()
    {
        Application.Quit();
    }
}