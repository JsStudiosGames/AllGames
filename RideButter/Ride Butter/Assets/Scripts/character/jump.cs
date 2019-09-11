using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class jump : MonoBehaviour {

    public GameObject character;

    private Charackermovmentpc otherscript;

    private float charge;

    private float chargestart;

    public Rigidbody rb;

    public float jumpforce;

   
    void Start()
    {
        otherscript = character.GetComponent<Charackermovmentpc>();
        charge = otherscript.charge;
        
        chargestart = otherscript.chargestart;
        Debug.Log(charge);
        Debug.Log(chargestart);
        rb = GetComponent<Rigidbody>();
        
    }
    void Update()
    {
        charge = otherscript.charge;
        chargestart = otherscript.chargestart;

        
       
    }
    void OnTriggerEnter(Collider other)
        {
        if (charge > 70)
        {
            rb.AddForce(transform.up * jumpforce);
           
        }
    }

    
    }




