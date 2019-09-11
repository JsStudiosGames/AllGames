using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Handler : MonoBehaviour {

    public GameObject normal;
    public GameObject basketball;
    public GameObject baseball;
    public GameObject soccor;

    void Update () {

		if (PlayerPrefs.GetInt("Selected", 1) == 1)
        {
            normal.SetActive(true);
            basketball.SetActive(false);
            baseball.SetActive(false);
            soccor.SetActive(false);
        }
        if (PlayerPrefs.GetInt("Selected", 1) == 2)
        {
            normal.SetActive(false);
            basketball.SetActive(true);
            baseball.SetActive(false);
            soccor.SetActive(false);
        }
        if (PlayerPrefs.GetInt("Selected", 1) == 3)
        {
            normal.SetActive(false);
            basketball.SetActive(false);
            baseball.SetActive(true);
            soccor.SetActive(false);
        }
        if (PlayerPrefs.GetInt("Selected", 1) == 4)
        {
            normal.SetActive(false);
            basketball.SetActive(false);
            baseball.SetActive(false);
            soccor.SetActive(true);
        }
    }
}
