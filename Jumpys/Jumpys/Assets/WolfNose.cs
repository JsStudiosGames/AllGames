using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WolfNose : MonoBehaviour {

    private GameObject wolf;
    private PvCWolfMovement script;

    private void Start()
    {
        wolf = GameObject.FindGameObjectWithTag("wolf");
        script = wolf.GetComponent<PvCWolfMovement>();
    }

    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "wolfNose")
        {
            Debug.Log("goJump");
            script.Jump();
        }
    }
}
