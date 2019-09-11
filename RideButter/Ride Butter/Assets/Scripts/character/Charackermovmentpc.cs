using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Charackermovmentpc : MonoBehaviour
{

    public float speed = 20f;

    public float charge = 1f;

    public float chargestart = 0f;

    public Rigidbody rb;

    public Text scoretext;

    private int score;



    private jump otherscript;

    public GameObject character;

    private tricks otherscript1;

    void Start()
    {
        charge = chargestart;
        rb = GetComponent<Rigidbody>();
        
        otherscript = character.GetComponent<jump>();
        otherscript1 = character.GetComponent<tricks>();
        
        score = otherscript1.score;
    }
   

    void Update()
    {
        scoretext.text = score.ToString();
        Vector3 pos = transform.position;
        score = otherscript1.score;


        if (Input.GetKey("d"))
        {
            pos.x += speed * Time.deltaTime;

        }
        if (Input.GetKey("a"))
        {
            pos.x -= speed * Time.deltaTime;

        }
        if (Input.GetKey("space"))
        {
           
            charge = charge + 1;
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
          
            charge = chargestart;
        }
        if (transform.position.y > 180)
        {

            Debug.Log("In the air");






            transform.position = pos;
        }
    }
}

    

