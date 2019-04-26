using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScreen : MonoBehaviour
{
    public AudioClip Trueno;

    private AudioSource PistaAudio;
    private bool clicked = false;
    private float cd;

    void Start()
    {
        PistaAudio = GetComponent<AudioSource>();
        cd = 3f;
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            PistaAudio.clip = Trueno;
            PistaAudio.Play();
            clicked = true;
        }

        if (clicked) cd -= Time.deltaTime;
        if (cd <= 0) SceneManager.LoadSceneAsync("MainMenu");
    }
}
