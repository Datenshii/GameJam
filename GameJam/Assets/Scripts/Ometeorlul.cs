using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ometeorlul : MonoBehaviour
{
    public Omegasplosionlul omegasplosionlul;
    private AudioSource PistaAudio;
    public AudioClip Explosion;

    void Start()
    {
        PistaAudio = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Enemy enemy = collision.GetComponent<Enemy>();

        if (enemy != null || collision.CompareTag("Ground"))
        {
            PistaAudio.clip = Explosion;
            PistaAudio.Play();
            Instantiate(omegasplosionlul, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
