using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScreen : MonoBehaviour {

    private AudioSource PistaAudio

    private void Start()
    {
        
    }

    void Update () {
		if(Input.GetButtonDown("Fire1")) {
            SceneManager.LoadSceneAsync("MainMenu");
        }
	}
}
