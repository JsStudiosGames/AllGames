using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
using UnityEngine.SceneManagement;

public class Ad : MonoBehaviour {

    public GameObject lose;

    public float timer;

    public bool update;

    public GameObject text;

	// Use this for initialization
	void Start () {
        timer = 5;
        update = false;
	}
	
	// Update is called once per frame
	void Update () {

        if (timer <= 0)
        {
            update = false;
            PlayAd();
            timer = 5;
        }
	    
        if (update == true)
        {
            timer -= Time.deltaTime;            
        }
	}

    void PlayAd()
    {
        if (Advertisement.IsReady())
        {
            Advertisement.Show();
            SceneManager.LoadScene(0);
        }
    }

    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Enemy")
        {
            EndGame();
            Debug.Log("Dead");
        }
    }
    IEnumerator End()
    {
        yield return new WaitForSeconds(2);
        lose.SetActive(true);
        text.SetActive(false);
        update = true;
        Debug.Log("End3");
    }

    void EndGame()
    {
        StartCoroutine(End());
        Debug.Log("End2");
    }
}
