using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drive : MonoBehaviour {
    public Transform Endpos;
    public float Speed;
	

	void Update () {

        transform.position = Vector3.MoveTowards(transform.position, Endpos.position, Speed * Time.deltaTime);
	}
}
