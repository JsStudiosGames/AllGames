using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{

    public int height;
    public int distance;
    public int width;
    public float heightpoint;
    public GameObject grass;
    public GameObject dirt;
    public GameObject stone;
    public float heightpoint2;
    public int space;

    // Use this for initialization
    void Start()
    {
        Generate();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void Generate()
    {
        distance = height;
        for (int w = 0; w < width; w++)
        {
            int lowernum = distance - 1;
            int heighernum = distance + 2;
            distance = Random.Range(lowernum, heighernum);
            space = Random.Range(12, 20);
            int stonespace = distance - space;


            for (int j = 0; j < stonespace; j++)
            {
                Instantiate(stone, new Vector3(w, j), Quaternion.identity);
            }

            for (int j = stonespace; j < distance; j++)
            {
                Instantiate(dirt, new Vector3(w, j), Quaternion.identity);
            }
            Instantiate(grass, new Vector3(w, distance), Quaternion.identity);
        }
    }
}
