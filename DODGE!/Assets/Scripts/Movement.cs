using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public Vector2 targetPos;

    public float speed;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.touchCount > 0)
        {
            this.transform.position = Vector2.MoveTowards(this.transform.position, targetPos, speed* Time.deltaTime);
        }

        if (Input.GetKey("space"))
        {
            this.transform.position = Vector2.MoveTowards(this.transform.position, targetPos, speed* Time.deltaTime);
        }
    }
}
