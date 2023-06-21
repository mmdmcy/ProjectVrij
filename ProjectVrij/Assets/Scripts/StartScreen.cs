using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScreen : MonoBehaviour
{
    public string SolitudeGame;

    public AudioSource SFX;
    public AudioClip Button;

    public float delayTime = 0.05f;

    public void StartGame()
    {
        SFX.clip = Button;
        SFX.Play();

        Invoke("DelayedAction", delayTime);
    }

    void DelayedAction()
    {
        SceneManager.LoadScene(SolitudeGame);
    }

    public void QuitGame()
    {
        SFX.clip = Button;
        SFX.Play();

        Invoke("DelayedActionQuit", delayTime);
    }

    void DelayedActionQuit()
    {
        Application.Quit();
        print("Quit");
    }
}
