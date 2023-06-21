using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cutscene : MonoBehaviour
{

    public Camera playerCam;
    public Camera cutsceneCam;
    public GameObject cutsceneCamera;


    // Start is called before the first frame update
    void Start()
    {
        playerCam.enabled = false;
        cutsceneCam.enabled = true;


        StartCoroutine(cameraChange());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator cameraChange()
    {
        yield return new WaitForSeconds(8);
        
        playerCam.enabled = true;
        cutsceneCam.enabled = false;
        cutsceneCamera.SetActive(false);
    }
}
