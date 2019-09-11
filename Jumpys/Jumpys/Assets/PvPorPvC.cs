using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PvPorPvC : MonoBehaviour {

    public void PvC()
    {
        SceneManager.LoadScene(2);
    }
    public void PvP()
    {
        SceneManager.LoadScene(1);
    }
}
