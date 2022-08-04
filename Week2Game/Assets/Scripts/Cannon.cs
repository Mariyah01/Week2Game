using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    //The cannon's mouth
    [SerializeField] private Transform bulletSpawnPoint;
    //The cannon's ammo
    [SerializeField] private GameObject bullet;
    // Start is called before the first frame update


    // Update is called once per frame
    //If the fire button is pressed, instantiate a bullet in the bullet's spawn point and rotate it accordingly
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(bullet, bulletSpawnPoint.position, transform.rotation);
        }
    }
}
