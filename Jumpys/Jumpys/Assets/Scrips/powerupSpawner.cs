using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerupSpawner : MonoBehaviour {

    public GameObject speedBoost;
    public GameObject sheild;
    public GameObject higherJump;

    public float yPoint;
    public float maxXPoint;
    public float minXPoint;

	// Use this for initialization
	void Start () {
        StartCoroutine(Powerup());
    }
	
	IEnumerator Powerup()
    {
        yield return new WaitForSeconds(5);
        float x = Random.Range(minXPoint, maxXPoint);
        int which = Random.Range(0, 100);
        if (which <= 40)
        {
            Instantiate(speedBoost, new Vector2(x, yPoint), Quaternion.identity);
        }else if (which <= 80)
        {
           Instantiate(higherJump, new Vector2(x, yPoint), Quaternion.identity);
        }else if (which <= 100)
        {
            Instantiate(sheild, new Vector2(x, yPoint), Quaternion.identity);
        }
        StartCoroutine(Powerup());
    }
}
