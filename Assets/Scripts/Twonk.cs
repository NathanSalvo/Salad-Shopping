using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelEnd : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collision)
    {if (collision.gameObject.tag == "Player")
        {SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
        }
    }
}    