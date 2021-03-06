﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementRight : MonoBehaviour {

    public float currentSpeed;
    public float maxSpeed;
    public float aclP;
    Rigidbody2D plRigidbody;
    public GroundCheckSCript gc;


    // Use this for initialization
    void Start()
    {
        plRigidbody = GetComponent<Rigidbody2D>();
    }

    public Vector2 movingC = new Vector2();
    public Vector2 movingD = new Vector2();
    public Vector2 jump = new Vector2();

    // Update is called once per frame
    void FixedUpdate()
    {
        currentSpeed = plRigidbody.velocity.x;

        if (!Input.GetKey(KeyCode.RightArrow) && Mathf.Abs(currentSpeed) < Mathf.Abs(maxSpeed) && plRigidbody.velocity.y > -1)
        {
            plRigidbody.AddForce(movingD);
        }

        //adding a right direction vector while under the max speed limit
        if (Mathf.Abs(currentSpeed) < Mathf.Abs(maxSpeed) && Input.GetKey(KeyCode.RightArrow))
        {
            plRigidbody.AddForce(movingC);
        }




        //checking ground check for jumping
        if (Input.GetKey(KeyCode.UpArrow) && plRigidbody.velocity.y < 0.1 && plRigidbody.velocity.y > -0.1 && gc.Grounded == true)
        {
            plRigidbody.AddForce(jump);
        }
    }
}
