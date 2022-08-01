using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class OnFall : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnCollisionEnter()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
