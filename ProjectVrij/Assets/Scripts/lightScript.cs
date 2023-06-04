using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightScript : MonoBehaviour
{
    public GameObject flashlight_ground, inticon, flashlight_player;

    //for audio
    public AudioSource Main;
    public AudioClip LightSwitch;

    void OnTriggerStay(Collider other) {
        if(other.CompareTag("MainCamera")) {
            inticon.SetActive(true);
            if(Input.GetKeyDown(KeyCode.E)) {
                flashlight_ground.SetActive(false);
                flashlight_player.SetActive(true);

                //play audio when flashlight goes on or off
                Main.clip = LightSwitch;
                Main.Play();
            }
        }
    }
    void OnTriggerExit(Collider other) {
        if(other.CompareTag("MainCamera")) {
            inticon.SetActive(false);
        }
    }
}
