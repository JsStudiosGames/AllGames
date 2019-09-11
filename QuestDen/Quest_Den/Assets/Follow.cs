using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour {

    public GameObject character;
    public SpriteRenderer render;
    private float yoffset;
    private float xoffset;
    public float yoffsetRight;
    public float xoffsetRight;
    public float yoffsetLeft;
    public float xoffsetLeft;

    private void Start()
    {
        xoffset = xoffsetRight;
        yoffset = yoffsetRight;
    }

    // Update is called once per frame
    void Update () {
        Vector2 pos = new Vector2(character.transform.position.x + xoffset, character.transform.position.y + yoffset);
        transform.position = pos;

        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
        {
            yoffset = yoffsetLeft;
            xoffset = xoffsetLeft;
            render.flipX = true;
        }

        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {
            yoffset = yoffsetRight;
            xoffset = xoffsetRight;
            render.flipX = false;
        }
    }
}
