using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PvCButtons : MonoBehaviour {

	public void Replay()
    {
        SceneManager.LoadScene(2);
    }
}
