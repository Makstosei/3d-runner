//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class PlayerRev : MonoBehaviour
//{

//    public Animator playerManager;
//    private Road previousRoad, lastRoad, passedRoad, currentRoad;
//    private int previousint, lastint, newint;


//    void Start()
//    {
//        lastint = GameManager.instance.Roads.Count - 1;
//        previousint = GameManager.instance.Roads.Count - 2;
//        previousRoad = GameManager.instance.Roads[previousint];
//        lastRoad = GameManager.instance.Roads[lastint];
//        passedRoad = GameManager.instance.Roads[0];
//    }

    



//    private void OnTriggerEnter(Collider other)
//    {
//        Debug.Log(other.transform.parent.gameObject.name);

//        if (other.gameObject.name == "Trigger")
//        {
//            passedRoad.gameObject.SetActive(false);
//            GameManager.instance.Roads.Remove(passedRoad);
//            GameManager.instance.PassedRoads.Add(passedRoad);
//            currentRoad = other.transform.parent.gameObject.GetComponent<Road>();
//            passedRoad = currentRoad;
//            NextRoad();

//        }
//    }

//    Road GetRoad(int roadID)
//    {
//        foreach (Road road in GameManager.instance.Roads)
//        {
//            if (road.roadID == roadID)
//            {
//                return road;

//            }
//        }
//        return GameManager.instance.Roads[0];

//    }

//    Road NextRoad()
//    {
//        int newint = Random.Range(0, GameManager.instance.Roads.Count);
//        if (newint == lastRoad.roadID || newint == previousRoad.roadID)
//        {
//            while (true)
//            {
//                newint = Random.Range(0, GameManager.instance.Roads.Count);
//                if (newint != lastRoad.roadID && newint != previousRoad.roadID)
//                    break;
//            }
//        }
//        return GetRoad(newint);
//    }








//    //void Start()
//    //{
//    //    playerManager = GetComponent<Animator>();


//    //    Invoke("DelayedStart", 0.3f);
//    //}


//    //void DelayedStart()
//    //{

//    //    currentRoad = GetRoad(0);
//    //    previousRoad = GetRoad(1);

//    //}




//    //Road NextRoad()
//    //{
//    //    int randomint = Random.Range(0, GameManager.instance.Roads.Count);
//    //    if (randomint == currentRoad.roadID || randomint == previousRoad.roadID)
//    //    {
//    //        while (true)
//    //        {
//    //            randomint = Random.Range(0, GameManager.instance.Roads.Count);
//    //            if (randomint != currentRoad.roadID && randomint != previousRoad.roadID)
//    //                break;
//    //        }
//    //    }
//    //    return GetRoad(randomint);
//    //}


//}
