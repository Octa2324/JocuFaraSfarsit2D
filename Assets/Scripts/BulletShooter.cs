using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletShooter : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        Collider2D playerCollider = GameObject.FindGameObjectWithTag("Player").GetComponent<Collider2D>();
        Collider2D bulletCollider = GetComponent<Collider2D>();
        Physics2D.IgnoreCollision(bulletCollider, playerCollider);

        rb.velocity = transform.right * speed; ;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        Debug.Log("Collision with: " + collision.gameObject.name);

        Obstacle obstacle = collision.GetComponent<Obstacle>();

        if(obstacle != null)
        {
            obstacle.TakeDamage(20);
        }
        Destroy(gameObject);
    }

  
}
