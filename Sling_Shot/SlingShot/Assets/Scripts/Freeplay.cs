using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Freeplay : MonoBehaviour {

    public static bool freeplay;

    public static int shake;

    public GameObject enemy;

    void Start () {

               
	}

    private void Update()
    {
        if (PlayerPrefs.GetInt("Freeplay", 0) == 0)
        {
            freeplay = false;
        }

        if (PlayerPrefs.GetInt("Freeplay", 0) == 1)
        {
            freeplay = true;
        }


        if (freeplay)
        {
            enemy.SetActive(false);
            enemy.GetComponent<BoxCollider2D>().enabled = false;
        }
        if (!freeplay)
        {
            enemy.SetActive(true);
            enemy.GetComponent<BoxCollider2D>().enabled = true;
        }
        Debug.Log(freeplay);
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            freeplay = false;
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            freeplay = true;
        }
    }
}
