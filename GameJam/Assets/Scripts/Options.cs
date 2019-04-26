using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;



public class Options : MonoBehaviour
{
    private AudioSource PistaAudio;
    public AudioClip Boton;

    private void Start()
    {
        PistaAudio = GetComponent<AudioSource>();
    }

    public void LoadSceneOnClick(string scene)
    {
        PistaAudio.clip = Boton;
        PistaAudio.Play ();
        SceneManager.LoadScene(scene);

    }

    public void ExitGame()
    {
        Application.Quit();
    }
}