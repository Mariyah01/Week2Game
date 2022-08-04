using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    //Enemy's bullet variables
    [SerializeField] private float bulletSpeed;
    [SerializeField] private float bulletLifespan;
    private Rigidbody _rigidbody;
    //Referencing player's health script
    private PlayerHealth _playerHealth;
    // Start is called before the first frame update
    void Start()
    {
        //Referencing the bullet's RigidBody 
        _rigidbody = GetComponent<Rigidbody>();
        //Adding force to the bullet's RigidBody; getting it to move in the right direction
        _rigidbody.AddForce(transform.forward*bulletSpeed);
        //Deleting the bullet after the life span, so that it disappears even if it didn't hit an enemy, preventing bullets from accumulating in the scene
        Invoke("Delete",bulletLifespan);
    }

    //The method invoked by invoke to delete the bullet after it's lifespan time has passed
    private void Delete()
    {
        Destroy(gameObject);
    }
    //When the bullet enters a collider, it checks if the collision was against the player, if so, it reduces the player's health, then destroy itself
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            _playerHealth = collision.gameObject.GetComponent<PlayerHealth>();
            _playerHealth.health--;
            Destroy(gameObject);
        }
    }
}
