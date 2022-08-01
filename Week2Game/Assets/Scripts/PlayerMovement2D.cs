using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement2D : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float speed;
    private Rigidbody RB;
    private Rigidbody movingGround;

    void Start()
    {
        RB = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 movement = new Vector2(Input.GetAxis("Horizontal") * speed, 0);
        RB.velocity = new Vector2(movement.x, RB.velocity.y);
    }
    

    // private void OnCollisionEnter(Collision collision)
    // {
    //     Debug.Log("I'm on the moving ground");
    //     if(gameObject.CompareTag("MovingGround"))
    //         collision.gameObject.transform.SetParent(gameObject.transform,true);
    // }
    //
    //
    // private void OnCollisionExit(Collision other)
    // {
    //     if(gameObject.CompareTag("MovingGround"))
    //         other.gameObject.transform.parent = null;
    // }
}
