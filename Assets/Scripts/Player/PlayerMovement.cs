using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed = 5f;

    public Rigidbody2D rb;
    public Animator animator;

    Vector2 movement;

    SpriteRenderer spriteRenderer;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {   
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
        spriteRenderer.flipX = movement.x < 0.01 ? true : false; 

        UpdateAnimation();
    }

 void OnCollisionEnter2D (Collision2D col) {
        if (col.gameObject.tag == "Acid") {
                    {SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+0);
        }
    }
 }
    
    void UpdateAnimation()
    {
        UpdateMovement();

        animator.SetFloat("Horizontal", movement.x);
        animator.SetFloat("Vertical", movement.y);
        animator.SetFloat("Speed", movement.sqrMagnitude);    
    }

    void UpdateMovement()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
        rb.MovePosition(rb.position + movement.normalized * moveSpeed * Time.fixedDeltaTime); 
    }
}
