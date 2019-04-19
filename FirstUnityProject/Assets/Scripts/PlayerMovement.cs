
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

       
        //Top
        if(Input.GetKey("w") == true)
        {
            //Time.deltaTime basically makes it so that every computer moves the cube at the same uniform speed
            rb.AddForce(0, 0, forwardForce * Time.deltaTime);    
        }
        //Bottom
        if (Input.GetKey("s") == true)
        {
            
            rb.AddForce(0, 0, -forwardForce * Time.deltaTime);
        }

        //Left
        if (Input.GetKey("a") == true)
        {

            rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        //Right
        if (Input.GetKey("d") == true)
        {

            rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        //If the player gets below -20 on the Y axis display game over
        if(rb.position.y < -5f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
