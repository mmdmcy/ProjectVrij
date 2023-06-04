using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FootstepSounds : MonoBehaviour
{
    public AudioSource Walk;
    public AudioSource Run;


    void Update()
    {
        //if the player presses inputs to move, start playing sounds
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            if(Input.GetKey(KeyCode.LeftShift))
            {
                //if the player presses shift play the running sound
                Run.enabled = true;
                Walk.enabled = false;
            } 
            else
            {  
                //if the player  does not press shift play the walking sound
                Run.enabled = false;
                Walk.enabled = true;
            }  
        }

        //if player stops pressing keys to walk stop the sounds
        if (Input.GetKeyUp(KeyCode.A) || Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyUp(KeyCode.W) || Input.GetKeyUp(KeyCode.UpArrow) || Input.GetKeyUp(KeyCode.S) || Input.GetKeyUp(KeyCode.DownArrow))
        { 
            Run.enabled = false;
            Walk.enabled = false;
        }

    }
}
