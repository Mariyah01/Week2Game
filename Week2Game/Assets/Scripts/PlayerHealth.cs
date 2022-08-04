using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{
    //Player health value
    public int health=100;
    //Player's respawn point
    [SerializeField] private Transform spawnPoint;
    //Player's Rigidbody
    private Rigidbody _rigidbody;
    //Player's movement script
    private PlayerMovement2D playerScript;
    //Enemy's transform
    private Transform enemy;

    private void Start()
    {
        //Reference the player's Rigidbody
        _rigidbody = GetComponent<Rigidbody>();
        //Reference the player's movement script
        playerScript = GetComponent<PlayerMovement2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //In every update, check if the health is below or equal to zero, if so, call the die method
        if (health <= 0)
            Die();
    }

    private void Die()
    {
        //Upon death, transform the player's position to the respawn point, and reinitialize the health value
        transform.position = spawnPoint.position;
        health = 100;
    }
    //Upon collision with the enemy, reduce health by 1, get the enemy's transform ,and call the damage method
    private void OnCollisionEnter(Collision collision)
        {
            if (collision.gameObject.CompareTag("Enemy"))
            {
                health--;
                enemy = collision.gameObject.transform;
                Damage();
            }

        }
    
    private void Damage()
    {
        //disable player's movement script
        playerScript.enabled = false;
        //push the player up
        _rigidbody.AddForce(Vector3.up*350);
        //If the player is on the left right of the enemy
        if(transform.position.x<enemy.position.x)
            //push the player to the left
            _rigidbody.AddForce(Vector3.right*-500);
        else
            //push the player to the right
            _rigidbody.AddForce(Vector3.right*500);
        //invoke movement enabling method one time
        Invoke("MoveAgain",1);
    }
    
    private void MoveAgain()
    {
        //enable the player's movement script
        playerScript.enabled = true;
    }

    

    private void OnCollisionStay(Collision collisionInfo)
    {
        //upon staying on an infected ground, reduce health by one
        if (collisionInfo.gameObject.CompareTag("InfectedGround"))
        {
            health--;
        }
    }
}
