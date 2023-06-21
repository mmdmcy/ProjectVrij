using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Flashlight : MonoBehaviour
{
    public Light light;
    public TMP_Text text;

    public TMP_Text batteryText;

    public float lifetime = 100;

    public float batteries = 0;

    public AudioSource flashON;
    public AudioSource flashOFF;

    public GameObject boven;
    public GameObject onder;

    public Camera playerCam;
    public Camera cutsceneCam;
    public GameObject cutsceneCamera;

    private bool on;
    private bool off;

    void Start()
    {
        text.text = "[F]Flashlight : " + lifetime + "%" ;
        light = GetComponent<Light>();

        off = true;
        light.enabled = false;

        boven.SetActive(false);
        onder.SetActive(false);

        cutsceneCamera.SetActive(false);
        cutsceneCam.enabled = false;
    }

    void Update()
    {
        text.text = "[F] Flashlight " + lifetime.ToString("0") + "%";
        batteryText.text = "[R] to recharge " + batteries.ToString();

        if(Input.GetButtonDown("flashlight") && off)
        {
            flashON.Play();
            light.enabled = true;
            on = true;
            off = false;
        }

        else if(Input.GetButtonDown("flashlight") && on)
        {
            flashOFF.Play();
            light.enabled = false;
            on = false;
            off = true;
        }

        if (on)
        {
            lifetime -= 1 * Time.deltaTime;
        }

        if(lifetime <= 0)
        {
            light.enabled = false;
            on = false;
            off = true;
            lifetime = 0;

            boven.SetActive(true);
            onder.SetActive(true);

            cutsceneCamera.SetActive(true);
            cutsceneCam.enabled = true;
            playerCam.enabled = false;
            
            StartCoroutine(blink());
        }

        if (lifetime >= 100)
        {
            lifetime = 100;
        }

        if (Input.GetButtonDown("reload") && batteries >= 1)
        {
            batteries -= 1;
            lifetime += 50;
        }

        if(Input.GetButtonDown("reload") && batteries == 0)
        {
            return;
        }

        if(batteries <= 0)
        {
            batteries = 0;
        }
    }

    IEnumerator blink()
    {
        yield return new WaitForSeconds(6);

        SceneManager.LoadScene(3);
    }
}
