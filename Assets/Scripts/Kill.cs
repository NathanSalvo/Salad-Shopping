
using UnityEngine;
using UnityEngine.SceneManagement;

public class Kill : MonoBehaviour
{
    

 void OnCollisonEnter2D(Collision2D Collision)
        {
            if (Collision.gameObject.tag=="Player")
                { SceneManager.LoadScene(1);}
        }
    }

    