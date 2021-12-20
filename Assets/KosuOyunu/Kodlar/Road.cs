using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road : MonoBehaviour
{
    public int roadID;
    public float roadLength;

    private void Start()
    {
        roadLength = transform.Find("Terrain").GetComponent<Terrain>().terrainData.size.z;
    }

    void Update()
    {
        transform.Translate(0f, 0f, -GameManager.instance.roadSpeed * Time.deltaTime);   
    }
}
