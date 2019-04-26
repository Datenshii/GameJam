using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rayolul : MonoBehaviour
{
    private float lightningDuration = 0.5f;

	private AudioSource PistaAudio;
	public AudioClip Electrico;

    void Start()
    {
		PistaAudio = GetComponent<AudioSource> ();

        Destroy(gameObject, lightningDuration);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        Enemy enemy = collision.GetComponent<Enemy>();
    
        if (enemy != null)
        {
            enemy.SmiteHit();
			PistaAudio.clip = Electrico;
			PistaAudio.Play ();
        }
    }
}
