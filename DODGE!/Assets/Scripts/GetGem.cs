using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.Advertisements;

public class GetGem : MonoBehaviour {

    public GameObject gem;

    public GameObject gem2;

    public GameObject reInsantiator;

    public GameObject particals;

    public GameObject blood;

   private float timer;

    private float timer2;

    private bool update;

    public GameObject gameover;

    public float score;

    public Text text;

    public float highscore;

    public Text text2;

    public AudioSource win;

    public AudioSource death;


	// Use this for initialization
	void Start () {
        timer = 1f;
        update = false;
        timer2 = 2f;
        score = 0f;
        highscore = 0f;
        update = false;
     

    }
	
    void Kill()
    {
        
        Debug.Log("YOULOSE!");
        if (score > PlayerPrefs.GetFloat("Highscore", 0))
        {
            PlayerPrefs.SetFloat("Highscore", score);
        }

        gameover.active = true;

        text2.text = PlayerPrefs.GetFloat("Highscore", 0).ToString();
      
    }


	

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Gem")
        {
            Instantiate(particals, transform.position, transform.rotation);

            Debug.Log("GemCollision");

            gem.transform.position = reInsantiator.transform.position;

            score = score + 1;

            win.Play();
        }

        if (coll.gameObject.tag == "Gem2")
        {

            Instantiate(particals, transform.position, transform.rotation);

            Debug.Log("GemCollision2");

            gem2.transform.position = reInsantiator.transform.position;

            score = score + 1;

            win.Play();
        }

        if (coll.gameObject.tag == "Knife")
        {
            
            Debug.Log("Goodnight");
            death.Play();
            Instantiate(blood, transform.position, transform.rotation);
            update = true;

        }

    }

   

    void Update()
    {

       


        text.text = score.ToString();

        text2.text = highscore.ToString();

        if (update == true)
        {

            timer -= Time.deltaTime;
        }

        if (timer <= 0)
        {
            Debug.Log("Goodnight2");
            Kill();
            timer2 -= Time.deltaTime;
        }

        if (timer2 <= 0)
        {
            if (Advertisement.IsReady())
            {
                Advertisement.Show();
            }
            SceneManager.LoadScene(0);
        }
    }

}
