using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointFollow : MonoBehaviour
{
    [SerializeField] private GameObject[] waypoints;
    private int currentWP = 0;

    [SerializeField] private float speed = 2f;
    private void Update()
    {
        if( Vector2.Distance(waypoints[currentWP].transform.position,  transform.position) < .1f)
        {
            currentWP++;
            if(currentWP >= waypoints.Length)
            {
                currentWP = 0;
            }
        }
        transform.position = Vector2.MoveTowards(transform.position, waypoints[currentWP].transform.position, Time.deltaTime * speed);
    }
}
