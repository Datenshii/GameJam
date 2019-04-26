using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powers : MonoBehaviour
{

    public Transform SmitePoint;
    public Transform MeteorFall;
    public GameObject Rayolul;
    public GameObject Meteorlul;

    private float smiteCd;
    private float meteorCd;
    private LevelManager levelManager;
	private AudioSource PistaAudio;
	public AudioClip Rayo;
    public AudioClip Meteorito;


    void Start()
    {
        levelManager = FindObjectOfType<LevelManager>();
		PistaAudio = GetComponent<AudioSource> ();
        smiteCd = 0f;
        meteorCd = 0f;
    }

    void Update()
    {
        smiteCd -= Time.deltaTime;
        meteorCd -= Time.deltaTime;

        if (Input.GetButtonDown("Fire1") && smiteCd <= 0)
        {
            if (meteorCd <= 0 && levelManager.scorePoints >= 50)
            {
                Meteor();
                meteorCd = 8f;
            }
            else if (smiteCd <= 0)
            {
                Smite();
                smiteCd = 1f;
            }
        }
    }

    void Meteor()
    {
        Instantiate(Meteorlul, MeteorFall.position, MeteorFall.rotation);
        PistaAudio.clip = Meteorito;
        PistaAudio.Play();
    }

    void Smite()
    {
        Instantiate(Rayolul, SmitePoint.position, SmitePoint.rotation);
		PistaAudio.clip = Rayo;
		PistaAudio.Play ();
    }
}
