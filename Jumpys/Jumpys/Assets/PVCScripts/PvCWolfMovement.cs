using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PvCWolfMovement : MonoBehaviour {

    public PvCCharacterController2D controller;
    public PvCStart ready;

    public Rigidbody2D rb;

    public SpriteRenderer render;

    public Animator anim;
    public Animator cam;

    public GameObject[] hp;
    public GameObject pigWins;
    public GameObject pig;
    public GameObject dirtParticals;
    public GameObject stoneParticals;

    public float runSpeed;
    public float dashForce;
    public float minRange;
    public float maxRange;
    public float choose;
    float horizontalMove = 0f;

    public int health = 5;
    public int level;

    public bool jump;
    public bool spawnParticals;
    public bool isSheild;
    public bool canJump;
    public bool direction;
    

    void Update()
    {
        if (ready.isReady)
        {
            if (pig.transform.position.x != transform.position.x)
            {
                if (pig.transform.position.x < transform.position.x)
                {
                    horizontalMove = -1 * runSpeed;
                    anim.SetBool("Run", true);
                    render.flipX = true;
                }
                else if (pig.transform.position.x > transform.position.x)
                {
                    horizontalMove = 1 * runSpeed;
                    anim.SetBool("Run", true);
                    render.flipX = false;
                }
            }            
            else
            {
                horizontalMove = 0 * runSpeed;
                anim.SetBool("Run", false);
            }

            if (transform.position.x < pig.transform.position.x + maxRange)
            {
                if (transform.position.x > pig.transform.position.x + minRange)
                {
                    if (canJump)
                    {
                        jump = true;
                        Debug.Log("Jump");
                        spawnParticals = true;
                        canJump = false;
                    }                 
                }
                
            }

            if (Input.GetKeyDown(KeyCode.RightShift))
            {
                if (render.flipX)
                {
                    rb.AddForce(Vector2.left * dashForce * 10000 * Time.deltaTime);
                }
                else if (!render.flipX)
                {
                    rb.AddForce(Vector2.right * dashForce * 10000 * Time.deltaTime);
                }
            }

            if (pig.transform.position.y > transform.position.y + 2)
            {
                if (direction)
                {
                    if (transform.position.x < 11.28)
                    {
                        horizontalMove = 1 * runSpeed;
                        anim.SetBool("Run", true);
                        render.flipX = false;
                        if (canJump)
                        {
                            jump = true;
                            Debug.Log("Jump");
                            spawnParticals = true;
                            canJump = false;
                        }
                    }
                    }else
                    {
                        direction = false;
                    }
                }

                if (!direction)
                {
                    if (transform.position.x < -12.02)
                    {
                        horizontalMove = -1 * runSpeed;
                        anim.SetBool("Run", true);
                        render.flipX = false;
                        if (canJump)
                        {
                            jump = true;
                            Debug.Log("Jump");
                            spawnParticals = true;
                            canJump = false;
                        }
                    }else
                    {
                        direction = true;
                    }
                }
            }
        if (health <= 0)
        {
            pigWins.SetActive(true);
        }
    }

    public void Jump()
    {
        if (canJump)
        {
            jump = true;
            Debug.Log("Jump");
            spawnParticals = true;
            canJump = false;
        }
    }

    void FixedUpdate()
    {
        controller.Move(horizontalMove * Time.fixedDeltaTime, false, jump);
        jump = false;
    }

    private void OnCollisionEnter2D(Collision2D coll)        
    {
        canJump = true;
        if (coll.gameObject.tag == "dirt")
        {
            if (spawnParticals)
            {
                GameObject gameObject = Instantiate(dirtParticals, transform.position, Quaternion.identity);
                spawnParticals = false;
                cam.SetTrigger("shake");
                Destroy(gameObject, 3f);
            }
        }

        if (coll.gameObject.tag == "stone")
        {
            if (spawnParticals)
            {
                GameObject gameObject = Instantiate(stoneParticals, transform.position, Quaternion.identity);
                spawnParticals = false;
                cam.SetTrigger("shake");
                Destroy(gameObject, 3f);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D coll)
    {
        canJump = true;
        if (coll.gameObject.tag == "pig")
        {
            if (!isSheild)
            {
                if (pig.transform.position.y > transform.position.y)
                {
                    cam.SetTrigger("shake");
                    health--;
                    int index = health - 1;
                    if (index >= 0)
                    {
                        hp[index].SetActive(true);
                        hp[health].SetActive(false);
                    }
                }
            }
            
        }
        if (coll.gameObject.tag == "MainCamera")
        {
            pigWins.SetActive(true);
        }
        if (coll.gameObject.tag == "bone")
        {
            Destroy(coll.gameObject);
            health++;
            int index = health - 1;
            if (index >= 0)
            {
                hp[index].SetActive(true);
                hp[index - 1].SetActive(false);
            }           
        }
    }
}
