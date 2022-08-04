using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement2D : MonoBehaviour
{
    //Movement speed
    [SerializeField] private float speed;
    //Player's Rigidbody
    private Rigidbody RB;


    void Start()
    {
        //Reference the player's Rigidbody
        RB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //Get the horizontal axis data (for 2D movement) multiplied by speed. Zero the Y axis.
        Vector2 movement = new Vector2(Input.GetAxis("Horizontal") * speed, 0);
        //Set the Rigidbody's velocity
        RB.velocity = new Vector2(movement.x, RB.velocity.y);
    }
    
}
