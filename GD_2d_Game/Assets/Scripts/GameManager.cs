using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject mainManu;

    public void startGame()
    {
        SceneManager.LoadScene("Level_02");
    }

    public void goBack()
    {
        SceneManager.LoadScene("Menu");
    }

    public void help()
    {
        SceneManager.LoadScene("Help");
    }

    public void quiteGame()
    {
        Application.Quit();
    }
}
