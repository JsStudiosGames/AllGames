using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Collisions : MonoBehaviour
{

    public Vector3 player;

    public GameObject blood;

    public AudioSource hit;

    public bool end;

    void Start()
    {
        end = false;
    }

    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            Kill();
        }
    }
    void Kill()
    {
        Debug.Log("End");
        Instantiate(blood, player, transform.rotation);
        hit.Play();
    }

  
}
