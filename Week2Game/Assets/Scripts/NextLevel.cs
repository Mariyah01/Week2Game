using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class NextLevel : MonoBehaviour
{
    [SerializeField] private string level;
    // Start is called before the first frame update
    private void OnCollisionEnter()
    {
        SceneManager.LoadScene(level);
    }
}
