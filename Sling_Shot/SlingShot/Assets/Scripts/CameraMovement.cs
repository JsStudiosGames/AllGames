using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {

    public Movement script;

    public GameObject player;

    private Vector3 camPos;

	// Use this for initialization
	void Start () {
        camPos = transform.position;
	}

    // Update is called once per frame
    void Update() {
        
        if (script.isAlive == true)
        {
            camPos.x = player.transform.position.x;
            transform.position = camPos;
        }
	}
}
