using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public DistanceJoint2D joint;

    public Animator anim;

    public GameObject setHook_Sound;

    public GameObject hook;
    public GameObject dirtParticals;
    public GameObject gameoverPanel;

    public Rigidbody2D rb;

    public LineRenderer line;

    public float speed;
    public float rbSpeed;

    public bool canClick;
    public bool hasStarted;
    public bool isAlive = true;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (transform.position.y <= -5.5)
        {
            Lose();
            Debug.Log("DownUnder");
        }

        line.SetPosition(0, transform.position);
        if (Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W))
        {
            joint.distance -= speed * Time.deltaTime;
        }

        if (Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S))
        {
            joint.distance += speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {
            rb.AddForce(Vector2.left * rbSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            rb.AddForce(Vector2.right * rbSpeed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.Space))
        {
            GetComponent<DistanceJoint2D>().enabled = false;
            GetComponent<LineRenderer>().enabled = false;
            hook.SetActive(false);
        }

        if (Input.GetMouseButtonDown(0) && !Buttons.paused)
        {
            if (canClick)
            {
                hasStarted = true;

                GameObject setHook = Instantiate(setHook_Sound, transform.position, Quaternion.identity);
                Destroy(setHook_Sound, 0.3f);
                GetComponent<DistanceJoint2D>().enabled = true;
                GetComponent<LineRenderer>().enabled = true;
                hook.SetActive(true);
                joint.connectedAnchor = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                joint.distance = Vector2.Distance(transform.position, joint.connectedAnchor);
                line.SetPosition(1, joint.connectedAnchor);
                GameObject particals = Instantiate(dirtParticals, joint.connectedAnchor, Quaternion.identity);
                Destroy(particals, 1f);
                hook.transform.position = joint.connectedAnchor;
                canClick = false;
            }
            else
            {
                GetComponent<DistanceJoint2D>().enabled = false;
                GetComponent<LineRenderer>().enabled = false;
                hook.SetActive(false);
            }
            canClick = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Enemy" || coll.gameObject.tag == "MainCamera")
        {
            Lose();
        }
    }

    private void OnCollisionEnter2D(Collision2D coll)
    {


        if (coll.gameObject.tag == "floor")
        {
            Lose();
        }
    }

    public void Lose()
    {
        Debug.Log("End");
        Destroy(joint);
        Destroy(line);
        hook.SetActive(false);
        isAlive = false;
        gameoverPanel.SetActive(true);
    }

    public void SetHook()
    {
        canClick = true;
    }
}
   
