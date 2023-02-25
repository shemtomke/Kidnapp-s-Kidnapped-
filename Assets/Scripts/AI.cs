using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AI : MonoBehaviour
{
    //follow the player when in range or when in contact
    public GameObject player;
    public float speed, detectionRange, detectionAngle;

    private void Update()
    {
        FollowPlayer();
    }
    void FollowPlayer()
    {
        // Calculate the distance to the player
        float distanceToPlayer = Vector3.Distance(transform.position, player.transform.position);

        // Calculate the angle to the player
        Vector3 directionToPlayer = player.transform.position - transform.position;
        float angleToPlayer = Vector3.Angle(directionToPlayer, transform.forward);

        // Check if the player is within the detection range and angle
        if (distanceToPlayer <= detectionRange && angleToPlayer <= detectionAngle / 2)
        {
            // Player detected, do something
            // ...
        }
        /*else if (player.isStealthMode)
        {
            // Player in stealth mode, reduce detection range and angle
            distanceToPlayer = distanceToPlayer * 0.5f;
            angleToPlayer = angleToPlayer * 0.5f;
        }*/
    }
}
