using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Options : MonoBehaviour
{
    public void LoadSceneOnClick(int sceneNo)
    {
        SceneManager.LoadScene(sceneNo);
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}