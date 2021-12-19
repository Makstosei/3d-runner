using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Road : MonoBehaviour
{
    public int roadID;
    public float roadLength;


    void Start()
    {
     
       
    
    }

    void Update()
    {
        transform.Translate(0f, 0f, -GameManager.instance.roadSpeed * Time.deltaTime);   
    }
}
