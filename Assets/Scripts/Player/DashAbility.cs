using System.Collections;
 using System.Collections.Generic;
 using UnityEngine;
 
 public class DashAbility : MonoBehaviour {
 
 
 
     public float boostCooldown = 3f;
     public float boostDuration = 0.5f;
     private float speedBoost = 10;
 
     private bool hasCooldown;
     private Vector3 normalMovementVector = Vector3.forward;
     private Vector3 currentMovementVector;
 
     void Start()
     {
         currentMovementVector = normalMovementVector;
 
         // doesn't allow to have speed right at the beginning
         // but comment it out if you want to have boost immediately at startup
         StartCoroutine(ActivateCooldown());
     }
     
     void Update()
     {
         if(Input.GetKeyDown(KeyCode.Space) && !hasCooldown)
         {
             // apply boost, i simply added another vector to it
             currentMovementVector += Vector3.forward * speedBoost; 
             // activate the cooldown and start the deactivation method for the boost
             StartCoroutine(ActivateCooldown());
             StartCoroutine(ResetMovementVector());
         }
         // just some basic movement for the test
         transform.Translate(currentMovementVector * Time.deltaTime);
     }
 
     IEnumerator ResetMovementVector()
     {
         // wait some seconds
         yield return new WaitForSeconds(boostDuration);
         // return to normal speed
         currentMovementVector = normalMovementVector;
         Debug.Log("boost ended");
     }
 
     IEnumerator ActivateCooldown()
     {
         // put some code to disable the boost-is-ready bar
         // diable the ability to use boost
         hasCooldown = true;
         // wait until the boost is ready again
         yield return new WaitForSeconds(boostCooldown);
         // make the boost usable
         hasCooldown = false;
         Debug.Log("boost ready"); 
         // put some code to enable the boost-is-ready bar
     }
 }
 