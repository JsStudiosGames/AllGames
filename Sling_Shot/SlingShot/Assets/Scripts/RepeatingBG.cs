using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatingBG : MonoBehaviour {

    public static float endX;
    public static float startX;
    private Vector2 pos;

	// Use this for initialization
	void Start () {
        pos.y = transform.position.y;
        pos.x = transform.position.x;
	}
	
	// Update is called once per frame
	void Update () {
        pos.x = transform.position.x;
        pos.x  += BGPos.speed;
        transform.position = pos;
        if (transform.position.x <= endX)
        {
            Debug.Log("Repete");
            Vector2 pos = new Vector2(startX, transform.position.y);
            transform.position = pos;
        }
	}
}
