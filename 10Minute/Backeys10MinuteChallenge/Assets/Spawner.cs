using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject enemy;

    public float start;
    private float end;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (end <= 0)
        {
            Instantiate(enemy);
            start = Random.Range(3f, 6f);
            end = start;
        }
        else
        {
            end -= Time.deltaTime;
        }
	}
}
