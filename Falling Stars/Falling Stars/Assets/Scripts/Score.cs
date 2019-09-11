using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public float time;

    public Text scoreText;

    public Text highscore;

	// Use this for initialization
	void Start () {
        time = 0;
	}
	
	// Update is called once per frame
	void Update () {
        time += Time.deltaTime;

        if (time > PlayerPrefs.GetFloat("Highscore", 0))
        {
            PlayerPrefs.SetFloat("Highscore", time);
        }

        scoreText.text = time.ToString("0");

        highscore.text = PlayerPrefs.GetFloat("Highscore",0).ToString("0");

        
	}
}
