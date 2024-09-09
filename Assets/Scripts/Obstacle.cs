using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private GameObject player;
    private float health = 20;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");   
    }

    public void TakeDamage(float damage)
    {
        health -= damage; ;
        if(health <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Border")
        {
            Destroy(this.gameObject);
        }

        else if(collision.tag == "Player")
        {
            Destroy(player.gameObject);
        }
    }
}
