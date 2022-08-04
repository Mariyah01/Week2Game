using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ChangeLevels : MonoBehaviour
{
    //Strings to hold the scenes values 
    [SerializeField] private string level1, level2, level3;
    // Start is called before the first frame update


    // Update is called once per frame
    //Load scenes when their numbers are pressed
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
            SceneManager.LoadScene(level1);
        if (Input.GetKeyDown(KeyCode.Alpha2))
            SceneManager.LoadScene(level2);
        if (Input.GetKeyDown(KeyCode.Alpha3))
            SceneManager.LoadScene(level3);
    }
}
