using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScreen : MonoBehaviour {


    private AudioSource PistaAudio;
    public AudioClip Trueno;


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
