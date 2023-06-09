using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScreen : MonoBehaviour
{
    public string StartScreen;

    public AudioSource SFX;
    public AudioClip Button;

    public GameObject fadeScreen;

    public float delayTime = 0.05f;

    private void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
        Cursor.visible = true;

        StartCoroutine(goAway());
    }

    public void MainMenu()
    {
        SFX.clip = Button;
        SFX.Play();

        Invoke("DelayedAction", delayTime);
    }

    void DelayedAction()
    {
        SceneManager.LoadScene(StartScreen);
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

    IEnumerator goAway()
    { 
       yield return new WaitForSeconds(2); 

       fadeScreen.SetActive(false);
    }
}
