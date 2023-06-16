using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TutorialScreen : MonoBehaviour
{
    [SerializeField] public string SolitudeGame;
    [SerializeField] public string MainMenu;

    [SerializeField] public AudioSource SFX;
    [SerializeField] public AudioClip Button;

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

    public void Back()
    {
        SFX.clip = Button;
        SFX.Play();

        Invoke("DelayedActionQuit", delayTime);
    }

    void DelayedActionQuit()
    {
        SceneManager.LoadScene(MainMenu);
    }
}
