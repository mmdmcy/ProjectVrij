using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Flashlight : MonoBehaviour
{
    public Light light;
    public TMP_Text text;

    public TMP_Text batteryText;

    public float lifetime = 100;

    public float batteries = 0;

    public AudioSource flashON;
    public AudioSource flashOFF;

    private bool on;
    private bool off;

    void Start()
    {
        text.text = "[F]Flashlight : " + lifetime + "%" ;
        light = GetComponent<Light>();

        off = true;
        light.enabled = false;
    }

    void Update()
    {
        text.text = "[F] Flashlight " + lifetime.ToString("0") + "%";
        batteryText.text = "[R] to rechage " + batteries.ToString();

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
}
