using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProtectMove : MonoBehaviour {

    private bool isCutting;

    Rigidbody2D rb;

    Camera cam;

	// Use this for initialization
	void Start () {
        rb = GetComponent<Rigidbody2D>();

        cam = Camera.main;
	}
	
	// Update is called once per frame
	void Update () {
		
        if (Input.GetMouseButtonDown(0))
        {
            StartCutting();
        }else if (Input.GetMouseButtonUp(0))
        {
            StopCutting();
        }

        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
        {
            StartCutting();
        }
        else if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Ended)
        {
            StopCutting();
        }


        if (isCutting)
        {
            UpdatePos();
        }

	}

    void UpdatePos()
    {
        rb.position = cam.ScreenToWorldPoint(Input.mousePosition);
    }

    void StartCutting()
    {
        isCutting = true;
    }

    void StopCutting()
    {
        isCutting = false;
    }
}
