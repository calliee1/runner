using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMneu : MonoBehaviour
{
    public GameObject MainMenuCanvas;

    private void Start()
    {
        //Time.timeScale = 0f;
    }

    public void Play()
    {
        Time.timeScale = 1f;
        SceneManager.LoadSceneAsync(0);
        Debug.Log("uhghghgj");
    }

    public void Settings()
    {

    }

    public void QuitGame()
    {
        Time.timeScale = 1f;
        Application.Quit();
    }
}
