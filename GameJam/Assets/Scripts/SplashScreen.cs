using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScreen : MonoBehaviour {

<<<<<<< HEAD
    private AudioSource PistaAudio;
    public AudioClip Trueno;
=======

    private AudioSource PistaAudio;
    public AudioClip Trueno;

>>>>>>> 995ba5e98271383ac7fcbe6a05a0bf65cf1665c2

    private void Start()
    {
        PistaAudio = GetComponent<AudioSource> ();
    }

    void Update () {
		if(Input.GetButtonDown("Fire1")) {
            PistaAudio.clip = Trueno;
            PistaAudio.Play ();
            SceneManager.LoadSceneAsync("MainMenu");
        }
	}
}
