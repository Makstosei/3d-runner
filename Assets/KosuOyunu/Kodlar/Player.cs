using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    
    public Road lastRoad, currentRoad;
    


    void Start()
    {
        Invoke("DelayedStart", 0.3f);
    }

    void DelayedStart()
    {
        lastRoad = GetRoad(0);
        currentRoad = GetRoad(1);

    }
    



    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.transform.parent.gameObject.name);

        if (other.gameObject.name == "Trigger")
        {
            

            lastRoad.gameObject.SetActive(false);
            
            Road newRoad = NextRoad();


            


            newRoad.gameObject.SetActive(true);

            newRoad.transform.localPosition = 
                new Vector3(0f, 
                0f, 
                currentRoad.transform.position.z 
                + currentRoad.roadLength);

            lastRoad = currentRoad;

            currentRoad = newRoad;

        }
    }

    Road GetRoad(int roadID)
    {
        foreach (Road road in GameManager.instance.Roads)
        {
            if (road.roadID == roadID)
            {
                return road;

            }
        }
        return GameManager.instance.Roads[0];

    }

    Road NextRoad()
    {
        int newint = Random.Range(0, GameManager.instance.Roads.Count);
        if (newint == lastRoad.roadID || newint == currentRoad.roadID)
        {
            while (true)
            {
                newint = Random.Range(0, GameManager.instance.Roads.Count);
                if (newint != lastRoad.roadID && newint != currentRoad.roadID)
                    break;
            }
        }
        return GetRoad(newint);
    }

   


}
