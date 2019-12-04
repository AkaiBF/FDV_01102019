using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour
{

    private GameController gameController;
    public GameObject GC;
    // Start is called before the first frame update
    void Start()
    {
        gameController = GC.GetComponent<GameController>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionStay2D(Collision2D other){
      Debug.Log("Hello");
      gameController.getCurrentCam().GetComponent<CamNoise>().Shake(0.1f);
    }
}
