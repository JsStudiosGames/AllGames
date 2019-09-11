using System.Collections;
using System.Collections.Generic;
using UnityEngine;

   public class EnemySpawner : MonoBehaviour {
    //Character
    public GameObject character;
    // List of Enemeys
    public GameObject m1;
    
    //For Spawning
    public Vector2 spawnpos;

    //Possible Positions
    private int left;
    private int right;
    private int up;
    private int down;    

	void Start () {
        // Starting spawning
		StartCoroutine(Spawn());
	}
	
	void Update () {
        // Generating available spawn points
        left = Mathf.RoundToInt(character.transform.position.x - 12);
        right = Mathf.RoundToInt(character.transform.position.x + 12);
        up = Mathf.RoundToInt(character.transform.position.y + 12);
        down = Mathf.RoundToInt(character.transform.position.y - 12);
        
    }

    IEnumerator Spawn()
    {
        // Waiting to spawn
        yield return new WaitForSeconds(1.5f);
        Monster1();
    }

    void Monster1()
    {
        // Spawning Monster
        spawnpos.x = Random.Range(left, right);
        //Start To Wait to Spawn
        StartCoroutine(Spawn());
        //Generating the chance of spawning
        float chance = Random.Range(0f, 100f);
        Debug.Log(chance);
        //Setting 40% chance to spwn
        if (chance <= 40)
        {
            //Spwning enemy
            GameObject instantiatedObject = Instantiate(m1, spawnpos, Quaternion.identity);
            //Adding enemy controller
            instantiatedObject.AddComponent<EnemyController>();
            chance = 100;
        }
    }
}

