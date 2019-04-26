using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScreen : MonoBehaviour {

<<<<<<< HEAD
    
    public AudioClip Trueno;

    private AudioSource PistaAudio;
    private bool clicked = false;
    private float cd;
=======

    private AudioSource PistaAudio;
    public AudioClip Trueno;

>>>>>>> 995ba5e98271383ac7fcbe6a05a0bf65cf1665c2

    private void Start()
    {
        PistaAudio = GetComponent<AudioSource> ();
        cd = 3f;
    }

    void Update () {
        if (clicked) cd -= Time.deltaTime;

		if(Input.GetButtonDown("Fire1")) {
            PistaAudio.clip = Trueno;
            PistaAudio.Play ();
            clicked = true;
        }
        if(cd <= 0) SceneManager.LoadSceneAsync("MainMenu");
    }
}
