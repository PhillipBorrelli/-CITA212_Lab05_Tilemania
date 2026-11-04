using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] float bulletspeed = 20f;
    Rigidbody2D myRigidbody;
    PlayerMovement player;
    float xSpeed;
 
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        player = FindAnyObjectByType<PlayerMovement>();
        xSpeed = player.transform.localScale.x * bulletspeed;
    }


    void Update()
    {
        myRigidbody.linearVelocity = new Vector2(xSpeed, 0f);
    }

    void OnTriggerEnter2D(Collider2D other)
    { 
        if (other.CompareTag("Enemy")) 
        { 
            Destroy(other.gameObject);
        }
        Destroy(gameObject);    
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        Destroy(gameObject, 1f);
    }
}
