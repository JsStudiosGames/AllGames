using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour {

	public void Play()
    {
        Time.timeScale = 1;
        Debug.Log("Play");
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quitting");
    }
}
