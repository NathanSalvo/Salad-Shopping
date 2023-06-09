using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamageController : MonoBehaviour
{
   [SerializeField] private int PlayerDamage;

   [SerializeField] private EnemyHealthController1 EnemyhealthController, Enemy, sal , bob;

//checks to see if collsion with Enemy then damage
   private void OnTriggerEnter2D(Collider2D collision)
   {
    if(collision.CompareTag("Enemy"))
    {
        Damage();
    }
   }
//runs updates Enemy health
   void Damage()
   {
        EnemyhealthController.EnemyHealth = EnemyhealthController.EnemyHealth - PlayerDamage;
        EnemyhealthController.UpdateHealth();
        
        Enemy.EnemyHealth = Enemy.EnemyHealth - PlayerDamage;
        Enemy.UpdateHealth();

        EnemyhealthController.EnemyHealth = EnemyhealthController.EnemyHealth - PlayerDamage;
        EnemyhealthController.UpdateHealth();

        sal.EnemyHealth = sal.EnemyHealth - PlayerDamage;
        sal.UpdateHealth();

        bob.EnemyHealth = bob.EnemyHealth - PlayerDamage;
        bob.UpdateHealth();

   }
}