using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerManager : MonoBehaviour
{
    public static bool isGameOver;
    public GameObject gameOverScreen;
    public GameObject scoreCounter;


    private void Awake()
    {
        isGameOver = false;
        Cursor.visible = false;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isGameOver)
        {   
            Invoke("gameOver", 1f);
        }
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
        scoreCounter.SetActive(false);
        Cursor.visible = true;
    }

    public void startGame()
    {
        SceneManager.LoadScene("Level_02");
    }

    public void mainMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    public void restartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void quiteGame()
    {
        Application.Quit();
    }
}
