using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Advertisements;
using UnityEngine.SceneManagement;

public class Lose : MonoBehaviour {

    public Movement script;

    public Text text;

    public GameObject Player1;
    public GameObject Dissapear1;
    public GameObject Dissapear2;
    public GameObject ball;
    public GameObject plop;
    public GameObject GameOver;
    public GameObject GameOverSound;

    private int score;

    public bool end;
    public bool count;
    public bool move1;
    public bool move2;

    public float countdown;
    public float wait;
    private float speed;

    public Vector2 plyr1pos;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        speed = script.speed;
        score = script.score;
        plyr1pos.x = -Player1.transform.position.x;
        transform.position = plyr1pos;

        if(move1 == true)
        {
            ball.transform.position = Vector3.MoveTowards(ball.transform.position, Dissapear2.transform.position, speed * Time.deltaTime);
        }

        if (move2 == true)
        {
            ball.transform.position = Vector3.MoveTowards(ball.transform.position, Dissapear1.transform.position, speed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Ball")
        {
            if (plyr1pos.x == -1)
            {
                Debug.Log("Move1");
                move1 = true;
            }
            if (plyr1pos.x == 1)
            {
                Debug.Log("Move2");
                move2 = true;
            }

            Instantiate(GameOverSound);
            GameOver.SetActive(true);
            end = true;
        }
    }

    public void Replay()
    {
        Instantiate(plop);
        SceneManager.LoadScene(1);
    }

    public void Home()
    {
        Instantiate(plop);
        SceneManager.LoadScene(0);
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

    public void PlayAd()
    {
        Debug.Log("PlayAd");
        Advertisement.Show();
    }

}
