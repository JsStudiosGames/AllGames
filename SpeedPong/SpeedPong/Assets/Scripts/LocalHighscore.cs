using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LocalHighscore : MonoBehaviour {

    public Text highscoretext;
    public Text money;

    void Start () {
        highscoretext.text = PlayerPrefs.GetInt("Highscore", 0).ToString();
        money.text = PlayerPrefs.GetInt("Money", 0).ToString();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
