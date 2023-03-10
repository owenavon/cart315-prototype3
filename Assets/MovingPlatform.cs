using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    [SerializeField] GameObject[] waypoints;
    int currentWaypointIndex = 0;

    [SerializeField] float speed = 1f;

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, waypoints[currentWaypointIndex].transform.position) < 0.1f) // Detects if platform touches the waypoint.
        {
            currentWaypointIndex++; // Switches direction to the other waypoint.
            if (currentWaypointIndex >= waypoints.Length)
            {
                currentWaypointIndex = 0; // Goes back to waypoint 1.
            }
        }

        transform.position = Vector3.MoveTowards(transform.position, waypoints[currentWaypointIndex].transform.position, speed * Time.deltaTime); // Frameway independent.
    }
}
