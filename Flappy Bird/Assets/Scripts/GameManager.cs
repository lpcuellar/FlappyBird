using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameOverCanvas;
    public GameObject keepingScore;
    public bool GameisPaused = false;
    public GameObject PausedUI;


    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("escape"))
        {
            if (GameisPaused)
            {
                Resume();
            }

            else
            {
                Pause();
            }
        }
    }

    public void GameOver()
    {
        gameOverCanvas.SetActive(true);
        keepingScore.SetActive(false);
        Time.timeScale = 0;
  
    }

    public void Replay()
    {
        SceneManager.LoadScene(1);
    }

    public void goMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void Resume()
    {
        PausedUI.SetActive(false);
        Time.timeScale = 1;
        GameisPaused = false;
    }

    public void Pause()
    {
        PausedUI.SetActive(true);
        Time.timeScale = 0;
        GameisPaused = true;
        keepingScore.SetActive(false);
    }

    public void Quit()
    {
        Application.Quit();
    }
}
