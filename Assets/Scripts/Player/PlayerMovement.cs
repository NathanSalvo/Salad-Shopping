using UnityEngine.SceneManagement;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float moveSpeed = 5f;

    public Rigidbody2D rb;
    public Animator animator;

    Vector2 movement;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {   
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");

        animator.SetFloat("Horizonal", movement.x);
        animator.SetFloat("Vertical", movement.x);
        animator.SetFloat("Speed", movement.magnitude);
    }

 void OnCollisionEnter2D (Collision2D col) {
        if (col.gameObject.tag == "Acid") {
                    {SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+0);
        }
    }
 }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * moveSpeed * Time.fixedDeltaTime);
    }
}
