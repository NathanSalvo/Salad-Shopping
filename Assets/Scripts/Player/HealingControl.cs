using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealingControl : MonoBehaviour
{
   [SerializeField] private int PlayerHealing;

   [SerializeField] private HealthController _healthController;

//checks to see if collsion with player then damage
   private void OnTriggerEnter2D(Collider2D collision)
   {
    if(collision.CompareTag("Player"))
    {
        Damage();
    }
   }
//runs updates player health
   void Damage()
   {
        _healthController.playerHealth = _healthController.playerHealth + PlayerHealing;
        _healthController.UpdateHealth();
        gameObject.SetActive(false);
   }
}
