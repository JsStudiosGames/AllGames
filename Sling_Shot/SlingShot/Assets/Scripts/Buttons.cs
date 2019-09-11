using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour {

    public static bool paused;

    public GameObject pausePanel;

    public void Retry()
    {
        SceneManager.LoadScene(1);
    }

    public void Menu()
    {
        SceneManager.LoadScene(0);
    }

    public void Resume()
    {
        Time.timeScale = 1f;
        paused = false;
        pausePanel.SetActive(false);
    }

    public void Play()
    {
        SceneManager.LoadScene(1);
    }

    void Pause()
    {
        Time.timeScale = 0f;
        paused = true;
        pausePanel.SetActive(true);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            if (paused)
            {
                Resume();
            }else
            {
                Pause();
            }
        }
    }
}
