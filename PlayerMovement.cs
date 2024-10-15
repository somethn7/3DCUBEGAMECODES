using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;
    public float forwardForce = 1000;
    public float sidewaysForce = 500f;
    
    
    void FixedUpdate()
    {
        rb.AddForce(0,0,2000 * Time.deltaTime);

        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(sidewaysForce*Time.deltaTime, 0,0, ForceMode.VelocityChange);
        }
        
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-sidewaysForce*Time.deltaTime, 0,0,ForceMode.VelocityChange);
        }

        if (rb.position.y<-1f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }



    }

}
    