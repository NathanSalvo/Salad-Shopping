using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public int damage = 2;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // thos funcial is called whenever something enters the enemy's collider
    private void OnCollisionEnter2d(Collision2D collision)
    {
       if(collision.gameObject.tag == "Player") 
       {
            playerHealth.TakeDamage(damage);
       }
    }
}
