using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{
    public GameObject[] waypoints;

    public float platformSpeed = 2;

    private int waypointsIndex = 0;




    void Update()
    {
        MovePlatform();
    }

    private void MovePlatform()
    {

        if (Vector3.Distance(transform.position, waypoints[waypointsIndex].transform.position) < 0.1f)


        {

            waypointsIndex++;

            if (waypointsIndex >= waypoints.Length)
            {
                waypointsIndex = 0;

            }
           




        }


        transform.position = Vector3.MoveTowards(transform.position, waypoints[waypointsIndex].transform.position, platformSpeed * Time.deltaTime);


    }
}