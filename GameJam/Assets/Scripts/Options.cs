using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Options : MonoBehaviour
{
    public AudioClip Boton;
    private AudioSource PistaAudio; 

    void Start()
    {
        PistaAudio = GetComponent<AudioSource>();
    }

    public void LoadSceneOnClick(string scene)
    {
        PistaAudio.clip = Boton;
        PistaAudio.Play();
        SceneManager.LoadScene(scene);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}