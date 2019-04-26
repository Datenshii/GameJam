using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powers : MonoBehaviour
{

    public Transform SmitePoint;
    public GameObject Rayolul;

    private float attackCd;
	private AudioSource PistaAudio;
	public AudioClip Rayo;

    void Start()
    {

		PistaAudio = GetComponent<AudioSource> ();
        attackCd = 1f;
    }

    void Update()
    {
        attackCd -= Time.deltaTime;

        if (Input.GetButtonDown("Fire1") && attackCd <= 0)
        {
            Smite();
            attackCd = 1f;
			        }
    }

    void Smite()
    {
        Instantiate(Rayolul, SmitePoint.position, SmitePoint.rotation);
		PistaAudio.clip = Rayo;
		PistaAudio.Play ();
    }
}
