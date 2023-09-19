using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public string sceneLoad;

    public void LoadGame()
    {
        SceneManager.LoadScene(sceneLoad);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
