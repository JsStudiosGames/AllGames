using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pickup : MonoBehaviour {

    // Spawning GameObjects
    public GameObject grass;
    public GameObject dirt;
    public GameObject stone;

    // Text to show ammount of GameObjects
    public Text GrassAmmount;
    public Text DirtAmmount;
    public Text StoneAmmount;

    // Amount of GameObjects
    private int Grass;
    private int Stone;
    private int Dirt;

    // Spawning
    private Vector2 spawnPos;    
    private GameObject SelectedObject;
    

    // Use this for initialization
    void Start () {
        SelectedObject = grass;
	}
	
	// Update is called once per frame
	void Update () {
        GrassAmmount.text = Grass.ToString();
        DirtAmmount.text = Dirt.ToString();
        StoneAmmount.text = Stone.ToString();
        spawnPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        spawnPos.x = Mathf.RoundToInt(spawnPos.x);
        spawnPos.y = Mathf.RoundToInt(spawnPos.y);
        if (Input.GetMouseButtonDown(1))
        {
            Spawn();
        }
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            Debug.Log("Grass");
            SelectedObject = grass;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            Debug.Log("Dirt");
            SelectedObject = dirt;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            Debug.Log("Stone");
            SelectedObject = stone;
        }
    }

    private void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.layer == 8)
        {
            Destroy(coll.gameObject);
            if(coll.gameObject.tag == "PickGrass")
            {
                Grass = Grass + 1;
            }
            if (coll.gameObject.tag == "PickDirt")
            {
                Dirt = Dirt + 1;
            }
            if (coll.gameObject.tag == "PickStone")
            {
                Stone = Stone + 1;
            }
        }
    }

    void Spawn()
    {
        if (SelectedObject != null)
        {
            if (SelectedObject == grass)
            {
                if (Grass > 0)
                {
                    Instantiate(SelectedObject, spawnPos, Quaternion.identity);
                    Grass = Grass - 1;
                }                
            }

            if (SelectedObject == dirt)
            {
                if (Dirt > 0)
                {
                    Instantiate(SelectedObject, spawnPos, Quaternion.identity);
                    Dirt = Dirt - 1;
                }
            }
            if (SelectedObject == stone)
            {
                if (Stone > 0)
                {
                    Instantiate(SelectedObject, spawnPos, Quaternion.identity);
                    Stone = Stone - 1;
                }
            }
        }
    }
}
