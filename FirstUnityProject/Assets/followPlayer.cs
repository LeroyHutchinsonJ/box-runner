using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followPlayer : MonoBehaviour
{
    //The transform data type gets the position of the player along with the scale and what not
    public Transform player;

    //Stores three float variable types
    public Vector3 offset;

    // Update is called once per frame
    void Update()
    {
 

     //The transform.position is the position of the camera, the player.position is the position of the player, the offset is the vector variable we made
        transform.position = player.position + offset;

        
    }
}
