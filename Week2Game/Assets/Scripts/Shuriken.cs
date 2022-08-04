using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shuriken : MonoBehaviour
{
    
    // Update is called once per frame
    void Update()
    {
        //upon each update, rotate the Shuriken around itself
        transform.Rotate(0f,0f ,100*Time.deltaTime , Space.Self);
    }
}
