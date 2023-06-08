using UnityEngine;

public class BabyProjectile : MonoBehaviour

{
    private Vector2 velocity; 
    private Rigidbody2D rb;
    private float range; 

    // Start is called before the first frame update
    void Start()
    {
        //spawns baby randomly
        velocity = new Vector2 (-2.0f, 0.0f); 
        rb = GetComponent<Rigidbody2D>(); 
        rb.velocity = velocity; 
        range = 5.0f;
        transform.position = new Vector3(transform.position.x, transform.position.y - range * Random.value, transform.position.z);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
