using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchCube : MonoBehaviour
{
    // Start is called before the first frame update
    private Rigidbody RB;
    void Start()
    {
        RB = GetComponent<Rigidbody>();
        RB.AddForce(Vector3.up*500);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
