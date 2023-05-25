using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashlightPage : MonoBehaviour
{
    private float deltaX;
    private float deltaY;
    private float angle;
    
    // Start is called before the first frame update
    // rotates the player towards to mouse
    private void RotateToMouse() {
        //mouse to world 
        Vector3 target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //work out the angle
        deltaX = target.x - transform.position.x;
        deltaY = target.y - transform.position.y;
        angle = Mathf.Atan2(deltaY, deltaX) * Mathf.Rad2Deg;
        //rotate 
        transform.rotation = Quaternion.Euler(0, 0, angle);

    }

    // Update is called once per frame
    public void Show()
    {
        gameObject.SetActive(true);
    }

    public void Hide()
    {
        gameObject.SetActive(false);
    }
}
