using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScreen : MonoBehaviour {

<<<<<<< HEAD
    private AudioSource PistaAudio;
    public AudioClip Trueno;
=======

>>>>>>> b95bdef44e7524d7eeb748b2777934027783f3f1

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
