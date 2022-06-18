using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FirstLevel : MonoBehaviour
{
    [SerializeField] private GameObject keyText;
    

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Player"))
        {
            if (NextLevel.numOFKey == 1)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
            else
            {
                keyText.SetActive(true);
                StartCoroutine(TextCoroutine());
                
            }
        }
    }

    IEnumerator TextCoroutine()
    {
        yield return new WaitForSeconds(2);
        keyText.SetActive(false);

    }
}
