using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamMovement : MonoBehaviour {

    public GameObject character;
    public Vector3 campos;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
        campos.x = character.transform.position.x;
        campos.y = character.transform.position.y;
        campos.z = -10;
        transform.position = campos;
    }
}
