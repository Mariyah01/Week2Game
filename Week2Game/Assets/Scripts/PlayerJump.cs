using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    //jump force determines the jump's height
    [SerializeField] private float jumpForce;
    //ground layer to check if the player is on the ground
    [SerializeField] private LayerMask groundLayer;
    //Player's grounding point to check if the player is on the ground
    [SerializeField] private Transform groundCheck;
    //Player's RigidBody
    private Rigidbody RB;
    //Boolean to check if the player can jump
    private bool canJump = true;
    void Start()
    {
        //The player's Rigidbody
        RB=GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //upon each update, check if there are any colliders between the player's position and the groundcheck position in the ground layer
        bool grounded = Physics.Linecast(transform.position, groundCheck.position, groundLayer);
        Debug.DrawLine(transform.position,groundCheck.position,Color.red);
        //If there is a collider(ground), then the player is grounded
        if (grounded == true)
        {
            //set the value of canJump
            canJump = true;
        }
        else
        {
            //set the value of canJump
            canJump = false;
        }
        //call the jump method
        jump();
    }

    void jump()
    {
        //If the jump button is pressed, and the player is on the ground, and therefore canJump
        if (Input.GetButtonDown("Jump")&& canJump == true)
        {
            //set canJump to false
            canJump = false;
            //Jump
            RB.AddForce(Vector3.up*jumpForce);
        }
    }
}
