using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Store : MonoBehaviour {

    public Text money;

    public Image normalimage;
    public Image basketballimage;
    public Image baseballimage;
    public Image soccorimage;

    public GameObject plop;

    public int score;

    public bool basketball;
    public bool baseball;
    public bool soccor;

    void Start () {

        score = PlayerPrefs.GetInt("Money", 0);
        if (PlayerPrefs.GetInt("Basketballtrue", 1) == 1)
        {
            PlayerPrefs.SetInt("Basketballtrue", 1);
        }
        if (PlayerPrefs.GetInt("Baseballtrue", 1) == 1)
        {
            PlayerPrefs.SetInt("Baseballtrue", 1);
        }
        if (PlayerPrefs.GetInt("Soccortrue", 1) == 1)
        {
            PlayerPrefs.SetInt("Soccortrue", 1);
        }

        if (PlayerPrefs.GetInt("Basketballtrue", 1) == 2)
        {
            basketball = true;
        }
        if (PlayerPrefs.GetInt("Baseballtrue", 1) == 2)
        {
            baseball = true;
        }
        if (PlayerPrefs.GetInt("Soccortrue", 1) == 2)
        {
            soccor = true;
        }
    }

    void Update()
    {
        PlayerPrefs.SetInt("Money", score);
        money.text = PlayerPrefs.GetInt("Money", 0).ToString();        
        if (PlayerPrefs.GetInt("Money", 0) >= 50)
        {
            basketball = true;
        }
        if (PlayerPrefs.GetInt("Money", 0) >= 100)
        {
            baseball = true;
        }
        if (PlayerPrefs.GetInt("Money", 0) >= 150)
        {
            soccor = true;
        }
        if (PlayerPrefs.GetInt("Selected", 1) == 1)
        {
            normalimage.color = new Color32(255, 255, 255, 75);
            basketballimage.color = new Color32(255, 255, 255, 0);
            baseballimage.color = new Color32(255, 255, 255, 0);
            soccorimage.color = new Color32(255, 255, 255, 0);
        }
        if (PlayerPrefs.GetInt("Selected", 1) == 2)
        {
            normalimage.color = new Color32(255, 255, 255, 0);
            basketballimage.color = new Color32(255, 255, 255, 75);
            baseballimage.color = new Color32(255, 255, 255, 0);
            soccorimage.color = new Color32(255, 255, 255, 0);
        }
        if (PlayerPrefs.GetInt("Selected", 1) == 3)
        {
            normalimage.color = new Color32(255, 255, 255, 0);
            basketballimage.color = new Color32(255, 255, 255, 0);
            baseballimage.color = new Color32(255, 255, 255, 75);
            soccorimage.color = new Color32(255, 255, 255, 0);
        }
        if (PlayerPrefs.GetInt("Selected", 1) == 4)
        {
            normalimage.color = new Color32(255, 255, 255, 0);
            basketballimage.color = new Color32(255, 255, 255, 0);
            baseballimage.color = new Color32(255, 255, 255, 0);
            soccorimage.color = new Color32(255, 255, 255, 75);
        }
        if (PlayerPrefs.GetInt("Basketballtrue", 1) == 1)
        {
            basketballimage.color = new Color32(0, 0, 0, 75);
        }
        if (PlayerPrefs.GetInt("Baseballtrue", 1) == 1)
        {
            baseballimage.color = new Color32(0, 0, 0, 75);
        }
        if (PlayerPrefs.GetInt("Soccortrue", 1) == 1)
        {
            soccorimage.color = new Color32(0, 0, 0, 75);
        }
    }

    public void Normal()
    {
        PlayerPrefs.SetInt("Selected", 1);
    }

    public void Basketball()
    {
        if (basketball == true)
        {
            Instantiate(plop);
            if (PlayerPrefs.GetInt("Basketballtrue", 1) == 1)
            {
                PlayerPrefs.SetInt("Basketballtrue", 2);
                score = score - 50;
                PlayerPrefs.SetInt("Selected", 2);
            }
            else
            {
                PlayerPrefs.SetInt("Selected", 2);
            }

        }
    }
  
    public void Baseball()
    {
        if (baseball == true)
        {
            Instantiate(plop);
            if (PlayerPrefs.GetInt("Baseballtrue", 1) == 1)
            {
                PlayerPrefs.SetInt("Baseballtrue", 2);
                score = score - 100;
                PlayerPrefs.SetInt("Selected", 3);
            }
            else
            {
                PlayerPrefs.SetInt("Selected", 3);
            }

        }
    }

    public void Soccer()
    {
        if (soccor == true)
        {
            Instantiate(plop);
            if (PlayerPrefs.GetInt("Soccortrue", 1) == 1)
            {
                PlayerPrefs.SetInt("Soccortrue", 2);
                score = score - 150;
                PlayerPrefs.SetInt("Selected", 4);
            }
            else
            {
                PlayerPrefs.SetInt("Selected", 4);
            }

        }
    }
    public void Back()
    {
        Instantiate(plop);
        SceneManager.LoadScene(0);
    }
}
