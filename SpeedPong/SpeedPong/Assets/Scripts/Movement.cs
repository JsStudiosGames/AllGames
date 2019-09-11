using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Movement : MonoBehaviour
{
    public GameObject player1;
    public GameObject player2;
    public GameObject pos1;
    public GameObject pos2;
    public GameObject pos3;
    public GameObject pos4;
    public GameObject end;
    public GameObject hitsound;
    public GameObject hit;
    public GameObject swish;

    public Animator anim;

    private bool GameOver;
    public bool left;

    public Lose script;

    public Text text;
    public Text highscoretext;

    private int spot;
    private int rand;
    public int score;

    public Vector2 char1pos;
    public Vector2 char2pos;

    public float speed;
    public float maxspeed;
    public float speedincrease;

    // Use this for initialization
    void Start()
    {
        script = end.GetComponent<Lose>();
    }

    // Update is called once per frame
    void Update()
    {
        if (score >= PlayerPrefs.GetInt("Highscore", 0))
        {
            PlayerPrefs.SetInt("Highscore", score);
        }
        highscoretext.text = PlayerPrefs.GetInt("Highscore", 0).ToString();

        GameOver = script.end;

        if (GameOver == false)
        {
            text.text = score.ToString();

            if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
            {                
                Instantiate(swish);
                if (left == false)
                {
                    Debug.Log("MoveLeft");
                    char1pos.x = -1;
                    left = true;
                }else if (left == true)
                {
                    Debug.Log("MoveRight");
                    char1pos.x = 1;
                    left = false;
                }              
            }

            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                Instantiate(swish);
                Debug.Log("MoveLeft");
                char1pos.x = -1;
            }
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                Instantiate(swish);
                Debug.Log("MoveRight");
                char1pos.x = 1;
            }

            player1.transform.position = char1pos;
            player2.transform.position = char2pos;

            if (spot == 1)
            {
                char2pos.x = -1;
                transform.position = Vector3.MoveTowards(transform.position, pos3.transform.position, speed * Time.deltaTime);
                return;
            }

            if (spot == 2)
            {
                char2pos.x = 1;
                transform.position = Vector3.MoveTowards(transform.position, pos4.transform.position, speed * Time.deltaTime);
                return;
            }

            if (spot == 3)
            {
                if (rand == 1)
                {
                    transform.position = Vector3.MoveTowards(transform.position, pos1.transform.position, speed * Time.deltaTime);
                    return;
                }
                if (rand == 2)
                {
                    transform.position = Vector3.MoveTowards(transform.position, pos2.transform.position, speed * Time.deltaTime);
                    return;
                }
                return;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (speed <= maxspeed)
        {
          speed = speed + speedincrease;
        }
      
        if (coll.gameObject.tag == "Player1")
        {
            GameObject identity = Instantiate(hitsound);
            Destroy(identity, 0.5f);

            Instantiate(hit, player1.transform.position, Quaternion.identity);
            anim.SetTrigger("Shake");

            Debug.Log("HitPlayer");
            if (char1pos.x == -1)
            {
                spot = 2;
            }

            if (char1pos.x == 1)
            {
                spot = 1;
            }
        }

        if (coll.gameObject.tag == "Player2")
        {
            GameObject identity = Instantiate(hitsound);
            Destroy(identity, 0.5f);

            Instantiate(hit, player2.transform.position, Quaternion.identity);
            anim.SetTrigger("Shake");
            score++;
            Debug.Log("HitEnemy");
            rand = Random.Range(1, 3);
            spot = 3;
        }
    }
}


