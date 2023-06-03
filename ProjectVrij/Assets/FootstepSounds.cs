using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootstepSounds : MonoBehaviour
{
    public AudioSource Main;


    void Update()
    {
        //if the player presses inputs to move, start playing footstep sounds
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            Main.enabled = true;
          
        }
        else
        // if they stop pressing the inputs, stop playing the footstep sounds
        {
            Main.enabled = false;
        }
    }
}
