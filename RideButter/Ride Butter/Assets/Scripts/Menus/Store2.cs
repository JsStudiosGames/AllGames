using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Store2 : MonoBehaviour {
    private int money;

    private Store otherscript;

    public GameObject character;

    public bool spin;

    public GameObject check2;

    public GameObject placeholder;

    // Use this for initialization
    void Start () {
        otherscript = character.GetComponent<Store>();
        money = otherscript.money;
        spin = false;

       
    }

    public void Spin()
    {
        if (money > 5499)
        {
            spin = true;
            check2.SetActive(true);
            placeholder.SetActive(true);
            money = money - 5500;
        }
    }
	
	
}
