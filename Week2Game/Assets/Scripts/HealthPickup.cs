using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class HealthPickup : MonoBehaviour
{
    //Player's health script
    private PlayerHealth _playerHealth;
    
    private void OnTriggerEnter(Collider other)
    {
        //When an object enters the trigger, check if this object is the player through comparing the Tag
        //If the object is the player
        if (other.gameObject.CompareTag("Player"))
        {
            //Reference the player's health script
            _playerHealth = other.gameObject.GetComponent<PlayerHealth>();
            //Access the health variable and increase the health by 10
            _playerHealth.health += 10;
            //Destroy the health pickup object
            Destroy(gameObject);
        }
    }
}
