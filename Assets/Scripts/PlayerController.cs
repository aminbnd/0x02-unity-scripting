using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 1000f;
    public Rigidbody rb;
    

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey("w") || Input.GetKey("up"))
        {
            rb.AddForce(0, 0, speed * Time.deltaTime);
        }

        if(Input.GetKey("s") || Input.GetKey("down"))
        {
            rb.AddForce(0, 0, -speed * Time.deltaTime);
        }

        if(Input.GetKey("a") || Input.GetKey("left"))
        {
            rb.AddForce(-speed * Time.deltaTime, 0, 0);
        }

        if(Input.GetKey("d") || Input.GetKey("right"))
        {
            rb.AddForce(speed * Time.deltaTime,0,0);
        }
    }
}