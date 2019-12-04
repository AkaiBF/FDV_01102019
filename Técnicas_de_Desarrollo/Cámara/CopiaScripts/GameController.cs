using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject camera1;
    public GameObject camera2;
    public GameObject camera3;
    private GameObject currentCam;
    // Awake is called before the game starts
    void Awake()
    {
      currentCam = camera2;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F1))
        {
            camera1.SetActive(true);
            camera2.SetActive(false);
            currentCam = camera1;
        }
        if (Input.GetKeyDown(KeyCode.F2))
        {
            camera2.SetActive(true);
            camera1.SetActive(false);
            currentCam = camera2;
        }
        if (Input.GetKeyDown(KeyCode.F3))
        {
            camera1.SetActive(false);
            camera2.SetActive(false);
            camera3.SetActive(true);
            currentCam = camera3;
        }
        if (Input.GetMouseButtonDown(0))
        {
          currentCam.GetComponent<CamNoise>().Shake(0.1f);
        }
    }

    public GameObject getCurrentCam(){
      return currentCam;
    }
}
