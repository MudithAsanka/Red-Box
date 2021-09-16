using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;    //Reference to Rigidbody

    public float forwardForce = 1000f;
    public float sidewaysForce = 100f;
    
    
    //Marked as Fixed because of using physics
    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if (Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce, 0,0);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce, 0,0);
        }

        if (rb.position.y < -1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}
