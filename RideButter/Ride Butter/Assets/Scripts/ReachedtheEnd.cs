using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReachedtheEnd : MonoBehaviour {

    public GameObject endgame;

   

    void Start()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "EndTrigger")
        {
            StartCoroutine(End());
        }

    }
    
    IEnumerator End()
    {
        Debug.Log("EndReached");
        endgame.SetActive(true);
        
        yield return new WaitForSeconds(5);
       
        endgame.SetActive(false);
        SceneManager.LoadScene(0);
        Debug.Log("EndReachedAgain");
    }
}
