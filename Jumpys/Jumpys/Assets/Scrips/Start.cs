using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Start : MonoBehaviour {

    public bool isReady = false;
    private bool wolfReady = false;
    private bool pigReady = false;
    private bool startTimer = false;
    private bool started = false;

    public float timer = 3;

    public GameObject waitPig;
    public GameObject waitWolf;
    public GameObject three;
    public GameObject two;
    public GameObject one;
    public GameObject go;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.A) || Input.GetKeyDown(KeyCode.D) || Input.GetKeyDown(KeyCode.E))
        {
            waitPig.SetActive(false);
            pigReady = true;
        }
        if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.LeftShift))
        {
            waitWolf.SetActive(false);
            wolfReady = true;
        }

        if (wolfReady && pigReady)
        {
            startTimer = true;
        }

        if (startTimer && !started)
        {
            timer -= Time.deltaTime;
        }

        if (timer <= 0)
        {
            go.SetActive(true);
            one.SetActive(false);
            timer = 100;
            started = true;
            isReady = true;
            StartCoroutine(GoDissapear());
        }
        else if (timer <= 1)
        {
            one.SetActive(true);
            two.SetActive(false);
        }
        else if (timer <= 2)
        {
            two.SetActive(true);
            three.SetActive(false);
        }
        else if (timer <= 2.999999)
        {
            three.SetActive(true);
        }
    }

    IEnumerator GoDissapear()
    {
        yield return new WaitForSeconds(1);
        go.SetActive(false);
    }
}
