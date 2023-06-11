using UnityEngine.SceneManagement;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    //ends game
    void OnCollisionEnter2D(Collision2D collision)
    {if (collision.gameObject.tag == "Player")
        { SceneManager.LoadScene(0);};
        }
    }  