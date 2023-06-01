using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    [SerializeField]
    private FlashlightPage flashlight;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            if (flashlight.isActiveAndEnabled == false)
            {
                flashlight.Show();
            }
            else
            {   
                flashlight.Hide();
            }
        }
    }
}
