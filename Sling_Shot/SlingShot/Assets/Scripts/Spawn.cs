using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {

    public GameObject roof;
    public GameObject floor;
    public GameObject player;
    public GameObject groundTop;
    public GameObject roofBottom;
    public GameObject particals;

    private Vector2 roofSize;
    private Vector2 roofgrassSize;
    private Vector2 floorSize;
    private Vector2 floorgrassSize;
    private Vector2 roofspawnPos;
    private Vector2 roofgrassspawnPos;
    private Vector2 floorspawnPos;
    private Vector2 floorgrassspawnPos;
    private Vector2 pos;

    public float minSize;
    public float maxSize;
    public float minfloorSize;
    public float maxfloorSize;
    public float distance;
    public float chance;
    private float spot;

    public Movement Script;
    public Sprites script;

    public Rigidbody2D rb;

    void Start () {

    }
        
    void Respawn()
    {
        roofSize.y = 1;
        roofSize.x = Random.Range(minSize, maxSize);
        roofspawnPos.y = 4.5f;
        roofspawnPos.x = spot + distance;
        roofgrassSize.y = 1;
        roofgrassSize.x = roofSize.x;
        roofgrassspawnPos.y = 4.26f;
        roofgrassspawnPos.x = roofspawnPos.x;        
        GameObject dirt = Instantiate(roof, roofspawnPos, Quaternion.identity);
        GameObject grass = Instantiate(roofBottom, roofgrassspawnPos, Quaternion.identity);
        dirt.transform.localScale = roofSize;
        grass.transform.localScale = roofgrassSize;
        script.SetDirt(dirt);
        script.SetGrass(grass);
    }

    void FloorRespawn()
    {
        int rand = Random.Range(0, 100);
        if (rand <= chance)
        {
            floorSize.y = Random.Range(minfloorSize, maxfloorSize);
            floorSize.x = Random.Range(1, 3);
            floorgrassSize.y = 1;
            floorgrassSize.x = floorSize.x;
            floorspawnPos.y = -5f + floorSize.y/2;
            floorspawnPos.x = spot + distance + 2;
            floorgrassspawnPos.y = -5f + floorSize.y - 0.24f;
            floorgrassspawnPos.x = spot + distance + 2;
            GameObject dirt = Instantiate(floor, floorspawnPos, Quaternion.identity);
            GameObject grass = Instantiate(groundTop, floorgrassspawnPos, Quaternion.identity);
            dirt.transform.localScale = floorSize;
            grass.transform.localScale = floorgrassSize;
            script.SetDirt(dirt);
            script.SetGrass(grass);
        }
        
    }

    private void Update()
    {
        
        if (pos.x >= spot + distance)
        {
            spot += distance;
            Debug.Log("Spawn");
            Respawn();
            FloorRespawn();
        }
        else
        {
            pos.x = transform.position.x;
        }
        if (Script.hasStarted)
        {
            distance += 0.2f * Time.deltaTime;
            particals.SetActive(true);
            rb.freezeRotation = false;
        }
    }
}
