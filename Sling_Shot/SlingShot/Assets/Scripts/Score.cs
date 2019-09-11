using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour {

    public Text scoreText;
    public Text endscoreText;
    public Text highscoreText;

    private int score;

    void Start()
    {

    }

    void Update () {
        score = Mathf.RoundToInt(transform.position.x)/10;
        scoreText.text = score.ToString();
        endscoreText.text = score.ToString();
        highscoreText.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
        if (score > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", score);
        }
    }
}
