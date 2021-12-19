using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public float roadSpeed = 10f;
    public List<Road> Roads = new List<Road>();
   

    private void Awake()
    {
        instance = this;
       
    }


    //public void AddList(int roadID,Road refRoad)
    //{
    //    if (Roads[roadID] == null)
    //    {
    //        Roads.Add(refRoad);

    //    }
    //    else
    //    {
    //        Road tempRoad = Roads[roadID];
    //        Roads[roadID] = refRoad;
    //        Roads.Add(tempRoad);

    //    }



    //}

   



}
