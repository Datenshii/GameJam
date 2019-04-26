using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Omegasplosionlul : MonoBehaviour
{
    private float explosionDuration = 0.3f;
    private AudioSource PistaAudio;
    public AudioClip Explosion;

    void Start()
    {
        PistaAudio = GetComponent<AudioSource>();
        Destroy(gameObject, explosionDuration);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Enemy enemy = collision.GetComponent<Enemy>();
        PistaAudio.clip = Explosion;
        PistaAudio.Play();

        if (enemy != null)
        {
            enemy.MeteorHit();
        }
    }
}
