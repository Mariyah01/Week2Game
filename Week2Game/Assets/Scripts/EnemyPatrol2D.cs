using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol2D : MonoBehaviour
{
    //Player's gameobject
    private GameObject player;
    //Boolean variable to check if the player is being detected
    private bool detected;
    //Enemy's speed, detection distance, and Rigidbody
    [SerializeField] private float speed;
    [SerializeField] private float detectionDistance=15;
    private Rigidbody _rigidbody;
    

    // Start is called before the first frame update
    void Start()
    {
        //Find the player through finding the player's tag
        player = GameObject.FindWithTag("Player");
        //Reference to the enemy's Rigidbody
        _rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //Check the player's distance from the enemy
        float playerDistance = Vector3.Distance(player.transform.position, transform.position);
        //The player's distance from the enemy
        detected = playerDistance <= detectionDistance;
        //If the player is within the detection range "is detected"
        if (detected)
        {
            //If the player is on the left side of the enemy
            if(player.transform.position.x<transform.position.x)
                //Push the enemy to the left side
                _rigidbody.AddForce(Vector3.right * -speed * Time.time);
            else
            {
                //Push the enemy to the right side
                _rigidbody.AddForce(Vector3.right * speed * Time.time);
            }

        }
    }
}
