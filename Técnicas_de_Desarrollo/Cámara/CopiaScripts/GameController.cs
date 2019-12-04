using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public Camera mainCamera;
    public GameObject camera1;
    public GameObject camera2;
    public GameObject camera3;
    private CinemachineBrain cinemaBrain;
    // Awake is called before the game starts
    void Awake()
    {
        cinemaBrain = mainCamera.GetComponent<CinemachineBrain>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F1))
        {
            camera1.SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.F2))
        {
            camera2.SetActive(true);
            camera1.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.F3))
        {
            camera1.SetActive(false);
            camera2.SetActive(false);
            camera3.SetActive(true);
        }
        if (Input.GetMouseButtonDown(0))
        {
          getCurrentCam().GetComponent<CamNoise>().Shake(0.1f);
        }
    }

    public GameObject getCurrentCam(){
        return cinemaBrain.ActiveVirtualCamera.VirtualCameraGameObject;
    }
}
