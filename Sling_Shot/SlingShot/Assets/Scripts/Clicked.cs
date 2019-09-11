using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Clicked : MonoBehaviour {

    private Movement script;

    private GameObject player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        script = player.GetComponent<Movement>();
    }

    private void OnMouseDown()
    {
        script.SetHook();
    }
}
