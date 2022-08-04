using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NextLevel : MonoBehaviour
{
    //Reference a scene from the serialized field
    [SerializeField] private string level;
    
    //On collision, check if the object is the player.
    //If the object is the player, load the scene referenced in the serialized field
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        SceneManager.LoadScene(level);
    }
}
