using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sprites : MonoBehaviour {

    public Sprite[] dirt;
    public Sprite[] grass;

	public void SetDirt(GameObject Dirt)
    {
        SpriteRenderer renderer = Dirt.GetComponent<SpriteRenderer>();
        int i = Random.Range(0, dirt.Length);
        renderer.sprite = dirt[i];
    }

    public void SetGrass(GameObject Grass)
    {
        SpriteRenderer renderer = Grass.GetComponent<SpriteRenderer>();
        int i = Random.Range(0, grass.Length);
        renderer.sprite = grass[i];
    }
}
