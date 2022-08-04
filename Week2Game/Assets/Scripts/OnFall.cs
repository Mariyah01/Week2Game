using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class OnFall : MonoBehaviour
{
    //On collision, check if the object is the player.
    //If the object is the player, load the active scene
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
