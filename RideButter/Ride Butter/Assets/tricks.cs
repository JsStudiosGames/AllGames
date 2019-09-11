using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tricks : MonoBehaviour {

   public bool inair;

    public Charackermovmentpc otherscript;

    public int score;

    public GameObject character;

    public bool didtrick;

    //Checks if in the air
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Plane")
        {
            inair = false;
        }
        else
        {
            inair = true;
        }
    }

    // Use this for initialization
    void Start () {
        otherscript = character.GetComponent<Charackermovmentpc>();
        inair = false;
    }

    // Update is called once per frame
    void Update () {

        //all of tricks go in here
        if (inair = false)
        {
            Debug.Log("CanDoTricks");
            didtrick = false;
            if (Input.GetKeyDown(KeyCode.G))
            {
                Grab();

            }

            if (Input.GetKeyDown(KeyCode.J))
            {
                Spin();

            }

            if (Input.GetKeyDown(KeyCode.F))
            {
                Flip();

            }
        }
        
        
    }

   

    //Script for grab
    void Grab()
    {
        Debug.Log("Grab");
        score = score + 10;
  
    }

    //Script for 180 and 360
    //Need to add 360
    void Spin()
    {
        Debug.Log("180");
        score = score + 25;
       
    }

    //Script for flip
    void  Flip()
    {
        Debug.Log("Flip");
        score = score + 50;
     
    }
}
