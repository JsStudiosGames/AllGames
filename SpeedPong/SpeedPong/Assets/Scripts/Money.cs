using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Money : MonoBehaviour {

    public GameObject money1;
    public GameObject money2;
    public GameObject player1;
    public GameObject pickUp;

    public Text text;

    private Vector2 playerpos;

    public int chance;
    public int score;

    private bool pos1 = false;
    private bool pos2 = false;

    private void Start()
    {
        score = PlayerPrefs.GetInt("Money", 0);
    }

    private void Update()
    {
        text.text = PlayerPrefs.GetInt("Money", 0).ToString();
        PlayerPrefs.SetInt("Money", score);
       

        playerpos = player1.transform.position;

        if (pos1 == true)
        {
            money1.SetActive(true);
            if (playerpos.x == 1)
            {
                money1.SetActive(false);
                Instantiate(pickUp);
                score++;
                pos1 = false;
            }
        }

        if (pos2 == true)
        {
            money2.SetActive(true);
            if (playerpos.x == -1)
            {
                money2.SetActive(false);
                Instantiate(pickUp);
                score++;
                pos2 = false;
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player2")
        {
            money1.SetActive(false);
            money2.SetActive(false);
            pos1 = false;
            pos2 = false;
            int rand = Random.Range(0, 100);
            if (rand <= chance)
            {
                if (playerpos.x == -1)
                {
                    pos1 = true;
                }

                if (playerpos.x == 1)
                {
                    pos2 = true;
                }
            }
        }
    }
}
