using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class NextLevel : MonoBehaviour
{

    public static int numOFKey = 0;



    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (SceneManager.GetActiveScene().name == "Level1")
        {
            if(NextLevel.numOFKey == 1)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
            else
            {
            }
        }


        if (collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
