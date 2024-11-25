using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Estrella : MonoBehaviour
{
    private bool interectable;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E) && interectable)
        {
            SceneManager.LoadScene("Victory");
        }
    }

    void InTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.CompareTag("Player"))
        {
            interectable = true;
        }
    }

    void OnTriggerExit2D(Collider2D collider)
    {
        if (collider.gameObject.CompareTag("Player"))
        {
            interectable = false;
        }
    }
}