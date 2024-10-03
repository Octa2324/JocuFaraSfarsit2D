using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Shoot : MonoBehaviour
{
    public Transform shootingPoint;
    public GameObject bulletPrefab;
    private SoundEffectsPlayer soundEffectsPlayer;

    void Start()
    {
        soundEffectsPlayer = FindObjectOfType<SoundEffectsPlayer>();
    }

    void Update()
    {
        if (Keyboard.current.spaceKey.wasPressedThisFrame)
        {
            Instantiate(bulletPrefab, shootingPoint.position, transform.rotation);
            soundEffectsPlayer.Shoot();
        }
    }
}
