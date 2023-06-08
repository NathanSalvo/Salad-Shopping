using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class McDamage : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
   {
    //resets level
    if(collision.CompareTag("Player"))
        { 
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+0);
        }
   }

}
