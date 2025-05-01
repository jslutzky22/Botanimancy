using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuControls : MonoBehaviour
{
    public void startGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
    public void LoadStartMenu()
    {
        SceneManager.LoadScene("MenuScene");

    }
    public void LoadLevel1()
    {
        SceneManager.LoadScene("Level1");

    }
    public void LoadLevel2()
    {
        SceneManager.LoadScene("Level2");

    }
    public void LoadLevel3()
    {
        SceneManager.LoadScene("Level3");

    }
}
