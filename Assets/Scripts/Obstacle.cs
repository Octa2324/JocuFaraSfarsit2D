using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    private GameObject player;
    private float health = 20;
    public ParticleSystem redParticles;
    public ParticleSystem blueParticles;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    public void TakeDamage(float damage)
    {
        health -= damage; ;
        if (health <= 0)
        {
            ParticleSystem redParticlesInstance = Instantiate(redParticles, transform.position, transform.rotation);
            redParticlesInstance.Play();
            Destroy(redParticlesInstance.gameObject, redParticlesInstance.main.duration + redParticlesInstance.main.startLifetime.constantMax);
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
            ParticleSystem blueParticlesInstance = Instantiate(blueParticles, transform.position, transform.rotation);
            blueParticlesInstance.Play();
            Destroy(blueParticlesInstance.gameObject, blueParticlesInstance.main.duration + blueParticlesInstance.main.startLifetime.constantMax);
            Destroy(player.gameObject);
        }
    }
}
