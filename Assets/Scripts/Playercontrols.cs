using UnityEngine;

public class Playercontrols : MonoBehaviour
{
    [Header("Movement")]
    public float speed = 3.0f;
    private Rigidbody2D body;

    private float deltaX;
    private float deltaY;
    private float angle;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void RotateToMouse() {
        Vector3 target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        deltaX = target.x - transform.position.x;
        deltaY = target.y - transform.position.y;
        angle = Mathf.Atan2(deltaY, deltaX) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, angle);
    }

    private void MovementPlayerBasedDiagonal() {
        float horizontal = Input.GetAxis("Horizonta;");
        float vertical = Input.GetAxis("Vertical");
        Vector2 forwards = transform.right * vertical;
        Vector2 sidewards = transform.up * horizontal * -1;
        body.velocity = (forwards + sidewards) * speed;
    }
}
