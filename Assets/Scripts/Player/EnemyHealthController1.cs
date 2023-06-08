using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnemyHealthController1 : MonoBehaviour
{
    public int EnemyHealth;

    [SerializeField] private Image[] hearts;

    private void Start()
    {
        UpdateHealth();
    }

//searches through hearts and updates based on health and restarts level
    public void UpdateHealth()
    {
        if(EnemyHealth <= 0)
         {   
            gameObject.SetActive(false);
         }

        for (int i = 0; i < hearts.Length; i++)
        {
            if(i < EnemyHealth)
            {
                hearts[i].color = Color.red;
            }
            else
            {
                hearts[i].color = Color.black;
            }
        }
    }
}
