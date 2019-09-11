using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knife2 : MonoBehaviour
{

    public Vector2 direction;

    public float speed;

    public float plusspeed;

    public float yspeed;

    // Use this for initialization
    void Start()
    {
        direction = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        direction.x = direction.x + speed;

        this.transform.position = direction;

        if (transform.position.x < -4.87)
        {
            speed = plusspeed* Time.deltaTime;
            this.GetComponent<SpriteRenderer>().flipX = false;
        }

        if (transform.position.x > 4.87)
        {
            speed = -speed * Time.deltaTime; ;
            this.GetComponent<SpriteRenderer>().flipX = true;
        }

        if (Input.touchCount > 0)
        {
            direction.y = direction.y - yspeed* Time.deltaTime;
        }

        if (Input.GetKey("space"))
        {
            direction.y = direction.y - yspeed* Time.deltaTime;
        }
    }
}
