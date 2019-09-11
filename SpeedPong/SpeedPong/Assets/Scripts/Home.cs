using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Home : MonoBehaviour {

    public GameObject plop;

	public void Play()
    {
        Instantiate(plop);
        SceneManager.LoadScene(1);
        Debug.Log("Play");
    }

    public void Store()
    {
        Instantiate(plop);
        SceneManager.LoadScene(2);
    }

    public void Leaderboard()
    {
        Instantiate(plop);
        SceneManager.LoadScene(3);
    }


    public void Quit()
    {
        Instantiate(plop);
        Application.Quit();
        Debug.Log("Quit");
    }
}
