using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundEffectsPlayer : MonoBehaviour
{
    public AudioSource src;
    public AudioClip shoot, boom, click;

    public void Shoot()
    {
        src.clip = shoot;
        src.Play();
    }
    public void Boom()
    {
        src.clip = boom;
        src.Play();
    }
    public void Click()
    {
        src.clip = click;
        src.Play(); 
    }
}
