using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour {

    //How much dammage it can take
    public float health;

    // How much damage is dealt
    public int ammount;

    // GameObject spawning
    public GameObject pickup;
    private Vector2 pos;

    private void Start()
    {   // Where to spawn block 
        pos.x = transform.position.x;
        pos.y = transform.position.y + 1;
    }

    private void OnMouseDown()
    {
        // Setting to decrease health
        TakeDamage(ammount);
    }

    private void Update()
    {
        // Checking ammount of health left
        if (health <= 0)
        {
            Die();
        }
    }

    public void TakeDamage(float ammount)
    {
        // Decreasing health
        health -= ammount;
    }

    void Die()
    {
        // Destroying GameObject
        Instantiate(pickup, pos, Quaternion.identity);
        Destroy(gameObject);
    }
}
