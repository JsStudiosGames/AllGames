using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {

	// Use this for initialization
	void Start () {
        StartCoroutine(Kill());
	}
	
	IEnumerator Kill()
    {
        yield return new WaitForSeconds(3);
        Destroy(gameObject);
    }
}
