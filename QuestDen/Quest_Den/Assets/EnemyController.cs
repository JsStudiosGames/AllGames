using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour {

    public float speed = 2;
    private bool canstart = false;
    private bool left = true;
    private Vector2 pos;

	// Use this for initialization
	void Start () {
		pos.y = 68.9f;
        pos.x = transform.position.x;
	}
	
	// Update is called once per frame
	void Update () {
        pos.y = transform.position.y;
        transform.position = pos;
        
	}

    private void OnCollisionEnter2D(Collision2D coll)
    {
       if (coll.gameObject.layer == 9)
        {
            canstart = true;
        } 
    }

    private void FixedUpdate()
    {
        if(canstart == true)
        {
            pos.x = pos.x - speed * Time.deltaTime;
        }
    }
}
