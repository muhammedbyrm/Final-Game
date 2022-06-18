using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartLevel : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            NextLevel.numOFKey = 0;
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
