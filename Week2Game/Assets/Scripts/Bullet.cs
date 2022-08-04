using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    //Bullet variables
    [SerializeField] private float bulletSpeed;
    [SerializeField] private float bulletLifespan;
    private Rigidbody _rigidbody;
    // Start is called before the first frame update
    void Start()
    {
        //Referencing the bullet's RigidBody 
        _rigidbody = GetComponent<Rigidbody>();
        //Adding force to the bullet's RigidBody; getting it to move in the right direction
        _rigidbody.AddForce(Vector3.right*bulletSpeed);
        //Deleting the bullet after the life span, so that it disappears even if it didn't hit an enemy, preventing bullets from accumulating in the scene
        Invoke("Delete",bulletLifespan);
    }

    //When the bullet enters a collider, it checks if the collision was against an enemy, if so, it destroys the enemy, then itself
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
    //The method invoked by invoke to delete the bullet after it's lifespan time has passed
    void Delete()
    {
        Destroy(gameObject);
    }
}
