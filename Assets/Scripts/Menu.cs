using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void MenuReturn()
    {
        Data.largeBall = false;
        SceneManager.LoadScene("Menu");
    }

    public void Credits()
    {
        SceneManager.LoadScene("EndCredits");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
