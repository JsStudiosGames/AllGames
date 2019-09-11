using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Store : MonoBehaviour {

    public int money;


    public GameObject check1;


    public Text moneyText;


    public bool tantrum;

    public GameObject placeholder;

    void Start()
    {
        
        tantrum = false;
        money = 0;
       
    }

    void Update()
    {
        moneyText.text = money.ToString();
    }

    public void Tantrum()
    {
        if (money > 4999)
            tantrum = true;
        check1.SetActive(true);
        placeholder.SetActive(true);
        money = money -5000;
    }
}



    



    

