using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarSpawner : MonoBehaviour {

    public GameObject star;

    public Transform[] spawnpoints;

    public float minDelay = .1f;
    public float maxDelay = 1f;

	// Use this for initialization
	void Start () {
        StartCoroutine(SpawnStars());
	}

    IEnumerator SpawnStars ()
    {
        while (true)
        {
            float delay = Random.Range(minDelay, maxDelay);

            yield return new WaitForSeconds(delay);

            int spawnIndex = Random.Range(0, spawnpoints.Length);

            Transform spawnPoint = spawnpoints[spawnIndex];

            GameObject spawnedFruit = Instantiate(star, spawnPoint.position, spawnPoint.rotation);

            Destroy(spawnedFruit, 3f);

        }
    }
}
