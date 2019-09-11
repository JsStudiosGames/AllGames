using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public float speed;

    public Movement script;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (script.hasStarted)
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime);
            speed += 0.25f * Time.deltaTime;        
        }       
	}
}
