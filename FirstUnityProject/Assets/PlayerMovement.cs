using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMovement : MonoBehaviour
{


    public Rigidbody rb;
    //Makes a variable to contain the forward force
    public float forwardForce = 1000f;
    public float sidewaysForce = 600f;

    // Update is called once per frame, unity prefers to used FixedUpdate for physic changes
    void FixedUpdate()
    {

       

        if(Input.GetKey("w") == true)
        {
            //Time.deltaTime basically makes it so that every computer moves the cube at the same uniform speed
            rb.AddForce(0, 0, forwardForce * Time.deltaTime);    
        }
        if (Input.GetKey("a") == true)
        {
            
            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("d") == true)
        {
           
            rb.AddForce(forwardForce * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey("s") == true)
        {
            
            rb.AddForce(0, 0, -sidewaysForce * Time.deltaTime);
        }

    }
}
