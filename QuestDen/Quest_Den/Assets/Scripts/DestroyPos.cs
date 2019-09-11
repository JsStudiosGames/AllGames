using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPos : MonoBehaviour
{
    Vector3 pos;
    Vector3 mousePos;
    Camera cam;
    private void Start()
    {
        cam = Camera.main;
    }

    void Update()
    {
        mousePos = Input.mousePosition;
        mousePos.z = cam.nearClipPlane;
        pos = cam.ScreenToWorldPoint(mousePos);
        pos.x = Mathf.RoundToInt(pos.x);
        pos.y = Mathf.RoundToInt(pos.y);
        transform.position = pos;
    }
}


