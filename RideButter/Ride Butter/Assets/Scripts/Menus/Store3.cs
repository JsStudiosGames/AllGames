using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Store3 : MonoBehaviour {
    private int money;

    private Store otherscript;

    public GameObject character;

    public bool raley;

    public GameObject check3;

    public GameObject placeholder;

    // Use this for initialization
    void Start () {
        otherscript = character.GetComponent<Store>();
        money = otherscript.money;
        raley = false;

    }

    public void Raley()
    {
        if (money > 8999)
        {
            raley = true;
            check3.SetActive(true);
            placeholder.SetActive(true);
            money = money - 9000;
        }
    }
}
