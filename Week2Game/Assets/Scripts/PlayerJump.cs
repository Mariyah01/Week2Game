using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float jumpForce;
    [SerializeField] private LayerMask groundLayer;
    [SerializeField] private Transform groundCheck;
    private Rigidbody RB;
    private bool canJump = true;
    void Start()
    {
        RB=GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        bool grounded = Physics.Linecast(transform.position, groundCheck.position, groundLayer);
        Debug.DrawLine(transform.position,groundCheck.position,Color.red);

        if (grounded == true)
        {
            canJump = true;
        }
        else
        {
            canJump = false;
        }
        
        jump();
    }

    void jump()
    {
        if (Input.GetButtonDown("Jump")&& canJump == true)
        {
            canJump = false;
            RB.AddForce(Vector3.up*jumpForce);
        }
    }
}
