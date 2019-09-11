using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fade : MonoBehaviour {

    private float TimeBtwSpawns;
    public float StartTimeBtwSpawns;

    public int ball;

    private GameObject spawn;
    public GameObject normal;
    public GameObject basketball;
    public GameObject soccorball;
    public GameObject baseball;
    public GameObject orange;

    void Update () {

        ball = PlayerPrefs.GetInt("Selected", 1);

        if (ball == 1)
        {
            spawn = normal;
        }
        if (ball == 2)
        {
            spawn = basketball;
        }
        if (ball == 3)
        {
            spawn = baseball;
        }
        if (ball == 4)
        {
            spawn = soccorball;
        }
        if (ball == 5)
        {
            spawn = orange;
        }

        if (TimeBtwSpawns <= 0)
        {
            GameObject instance = Instantiate(spawn, transform.position, Quaternion.identity);
            TimeBtwSpawns = StartTimeBtwSpawns;
            Destroy(instance, 0.2f);
        }
        else
        {
            TimeBtwSpawns -= Time.deltaTime;
        }
	}
}
