using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SetHighscores : MonoBehaviour {

    public InputField field;

    public string username;

    private void Update()
    {
        username = field.text;
    }

    public void SetHighscore()
    { 
        PublicHighscores.AddNewHighscore(username, PlayerPrefs.GetInt("Highscore", 0));
    }

    public void Back()
    {
        SceneManager.LoadScene(0);
    }
}
