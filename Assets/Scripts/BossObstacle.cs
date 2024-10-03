using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossObstacle : MonoBehaviour
{
    private GameObject player;
    private float health = 60;
    public ParticleSystem redParticles;
    public ParticleSystem blueParticles;
    private SoundEffectsPlayer soundEffectsPlayer;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        soundEffectsPlayer = FindObjectOfType<SoundEffectsPlayer>();
    }

    public void TakeDamage(float damage)
    {
        health -= damage; ;
        if (health <= 0)
        {
            soundEffectsPlayer.Boom();


            ParticleSystem redParticlesInstance = Instantiate(redParticles, transform.position, transform.rotation);
            redParticlesInstance.Play();
            Destroy(redParticlesInstance.gameObject, redParticlesInstance.main.duration + redParticlesInstance.main.startLifetime.constantMax);
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Border")
        {
            Destroy(this.gameObject);
        }

        else if (collision.tag == "Player")
        {
            soundEffectsPlayer.Boom();
            ParticleSystem blueParticlesInstance = Instantiate(blueParticles, transform.position, transform.rotation);
            blueParticlesInstance.Play();
            Destroy(blueParticlesInstance.gameObject, blueParticlesInstance.main.duration + blueParticlesInstance.main.startLifetime.constantMax);
            Destroy(player.gameObject);
        }
    }
}
