using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public enum GameState { Idle, Playing, Ended }

public class GameController : MonoBehaviour 
{

	public float parallaxSpeed = 0.02f;
	public RawImage background;
	public RawImage background2;
	public RawImage platform;
    public GameObject uiIdle;

	public GameState gameState = GameState.Idle;

    public GameObject player;
    public GameObject rockGenerator;

	// Use this for initialization
	void Start () 
    {
		
	}
	
	// Update is called once per frame
	void Update () 
    {

		//Empieza el juego
		if (gameState == GameState.Idle && (Input.GetKeyDown("up") || Input.GetMouseButtonDown(0)))
        {
			gameState = GameState.Playing;
            uiIdle.SetActive(false);
            player.SendMessage("UpdateState", "PlayerRun");
            rockGenerator.SendMessage("StartGenerator");
        }
        //Juego en marcha
        else if (gameState == GameState.Playing)
        {
            Parallax();
        }

        //Juego finalizado
        else if (gameState == GameState.Ended)
        {
            //to do
        }
    }
    void Parallax()
    {
         float finalSpeed = parallaxSpeed * Time.deltaTime;
         background.uvRect = new Rect(background.uvRect.x + finalSpeed, 0f, 1f, 1f);
         background2.uvRect = new Rect(background2.uvRect.x + finalSpeed, 0f, 1f, 1f);
         platform.uvRect = new Rect(platform.uvRect.x + finalSpeed * 4, 0f, 1f, 1f);
    }
    
}
