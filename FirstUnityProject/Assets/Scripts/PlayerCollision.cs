using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    //Create an object that can control the player movement, to be able to hold player movement you have to be the same object type as the class that controls player movement
    public PlayerMovement movement;
    //This function basically says 'When we hit something, I will..."  the parameter basically gets information about what we hit
    void OnCollisionEnter(Collision collisionInfo)
    {
        //This says "If the tag of the thing we hit is 'obstacle'
        if(collisionInfo.collider.tag == "Obstacle")
        {
            //Turn off the player movement
            movement.enabled = false;

            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
