using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Closing : MonoBehaviour {

    public GameObject player;
    public GameObject enemy;

    public Movement script;

    public Image image;

    public Color color;

    private float distance;
    public float distanceClose;
    public float distanceMid;
    public float distanceFar;
	
	void Update () {
            distance = player.transform.position.x - enemy.transform.position.x;
            if (script.hasStarted)
            {
                image.color = color;
            }
        
            if (distance <= distanceClose)
            {
                color.a = 0.4f;
                Debug.Log("Close");
            }
            else if (distance <= distanceMid)
            {
                color.a = 0.2f;
                Debug.Log("Mid");
            }
            else if (distance <= distanceFar)
            {
                color.a = 0.1f;
                Debug.Log("Far");
            }

            if (distance > distanceFar)
            {
                color.a = 0f;
                Debug.Log("OOR");
            }
    }
}
