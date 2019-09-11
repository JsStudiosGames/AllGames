using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {

    private GameObject Enemy;
    public GameObject dirtParticals;
    public GameObject collisionSound;
    public GameObject destroySound;

    private Vector2 spawnPoint;

    void Start () {
        Enemy = GameObject.FindGameObjectWithTag("Enemy");
    }

    void Update()
    {
        if (Enemy.transform.position.x >= transform.position.x)
        {
            Destroy(gameObject);
            Debug.Log("Destroy");
            GameObject destroy = Instantiate(destroySound, transform.position, Quaternion.identity);
            Destroy(destroy, 0.3f);
        }
    }

    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "Player")
        {
            GameObject collision = Instantiate(collisionSound, transform.position, Quaternion.identity);
            Destroy(collision, 0.3f);
            if (this.tag == "floor")
            {
                spawnPoint.y = transform.position.y + transform.position.y / 2;
                spawnPoint.x = transform.position.x;

                Instantiate(dirtParticals, spawnPoint, Quaternion.identity);
            }

            if (this.tag == "roof")
            {
                spawnPoint.y = transform.position.y;
                spawnPoint.x = transform.position.x;

                Instantiate(dirtParticals, spawnPoint, Quaternion.identity);
            }
        }
    }
}
