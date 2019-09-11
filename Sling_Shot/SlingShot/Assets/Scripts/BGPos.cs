using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGPos : MonoBehaviour {

    public static float speed;
    public float start;
    public float end;

	void Start () {
		
	}
	
	void Update () {
        speed = transform.position.y;
        RepeatingBG.startX = transform.position.x + start;
        RepeatingBG.endX = transform.position.x + end;
    }
}
