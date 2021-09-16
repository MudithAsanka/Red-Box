using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;    //Reference to Rigidbody

    public float forwardForce = 2000f;
    public float sidewayForce = 500f;
    
    
    //Marked as Fixed because of using physics
    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewayForce, 0,0);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewayForce, 0,0);
        }
    }
}
