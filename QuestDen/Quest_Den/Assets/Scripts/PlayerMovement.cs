using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    // Other script
    public CharacterController2D controller;

    //Speeds
    float horizontalmove = 0;
    public float runspeed = 40f;
    float origrunspeed;
    public float origjumpPower;
    private float jumpPower;
    public Animator anim;


    // If touching ground
    public bool touchingGround;

    private void Start()
    {
        origrunspeed = runspeed;
    }

    void Update () {
        horizontalmove = Input.GetAxisRaw("Horizontal") * runspeed;
        jumpPower = origjumpPower * Time.deltaTime;

        Rigidbody2D rb = GetComponent<Rigidbody2D>();
            if (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W))
             if(touchingGround == true)
            {
                touchingGround = false;
                runspeed = runspeed - 10f;
                anim.SetTrigger("Jump");
                rb.AddForce(Vector2.up * jumpPower);
            }
                
            if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.RightArrow))
        {
            anim.SetBool("Run",true);
        }
        else
        {
            anim.SetBool("Run", false);
        }
 
	}

    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.layer == 9)
        {
            runspeed = origrunspeed;
            touchingGround = true;
        }
    }

    void FixedUpdate()
    {
        //Move Character
        controller.Move(horizontalmove * Time.fixedDeltaTime, false, false);
    }
}
