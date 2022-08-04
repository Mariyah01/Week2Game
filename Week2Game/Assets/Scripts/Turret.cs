using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    //Player's transform
    private Transform player;
    //Boolean to check if the player is detected
    private bool detected;
    //Turret's detection distance
    [SerializeField] private float detectionDistance=5;
    //Turret's mouth
    [SerializeField] private Transform bulletSpawnPoint;
    //Turret's ammo
    [SerializeField] private GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        //Find the player using his tag
        player = GameObject.FindWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        //Transform the turret to look at the player
        transform.LookAt(player);
        //Call detecting player method
        DetectingPlayer();
    }

    private void DetectingPlayer()
    {
        //The distance between the player and the turret
        float playerDistance = Vector3.Distance(player.transform.position, transform.position);
        //If the distance between the player and turret is less than the detection distance, returns true
        detected = playerDistance <= detectionDistance;
        //If detected
        if (detected)
        {
            //If the player is on the left side of the turret
            if(player.transform.position.x<transform.position.x)
                //Shoot repeatedly
                InvokeRepeating("Shooting",1,1);
            else
                //Cancel shooting
                CancelInvoke("Shooting");
        
        }
    }

    private void Shooting()
    {
        //Instantiate bullets in the turret's mouth and rotate them 
        Instantiate(bullet, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
    }
}
