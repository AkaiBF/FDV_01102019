using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//Importar desde UI

public class GameController : MonoBehaviour 
{
	//3 variables públicas para gestionar velocidad de movimiento de fondo y mar.
	public float parallaxSpeedBackground = 0.02f;
	public float parallaxSpeedseaFront = 0.06f;
	public float parallaxSpeedseaMiddle = 0.05f;
	public float parallaxSpeedseaBack = 0.04f;

	public RawImage background;
	public RawImage seaFront;
	public RawImage seaMiddle;
	public RawImage seaBack;
            //Importo el gameObject UI_idle para desactivar el texto cuando el estado sea playing
            public GameObject UI_idle;

        //Con la función enumerador de c# creamos los estados del juego: Idle y Playing
        public enum GameState {Idle, Playing}
        //Creamos una instancia del enumerador
         public GameState gameState = GameState.Idle;

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
            //Detectamos el momento de inicio del juego
            //Condición: estado del juego idle + pulsar ratón o teclado
            if (gameState == GameState.Idle && (Input.GetKeyDown("up") || Input.GetMouseButtonDown(0)))
            {
                gameState = GameState.Playing;

                    //Además desactivamos texto del UI
                    UI_idle.SetActive(false);
            }

            //Si no se cumple la condición es porque es estado del juego es playing
            //En ese caso ejecutamos el parallax
            else if (gameState == GameState.Playing)
            {
                Parallax();
            }

	    
	}
    //Metemos el código del parallax dentro de un método que llamaremos para el estado playing del juego
    void Parallax()
    {
        //Calcular la velocidad final, ya que dependiendo del framerate del ordenador en sí, la velocidad puede variar.	
        //Para evitar esto y que sea una velocidad constante:	
        float finalSpeedBackground = parallaxSpeedBackground * Time.deltaTime;
        float finalSpeedseaFront = parallaxSpeedseaFront * Time.deltaTime;
        float finalSpeedseaMiddle = parallaxSpeedseaMiddle * Time.deltaTime;
        float finalSpeedseaBack = parallaxSpeedseaBack * Time.deltaTime;
        //Incrementamos la velocidad del componente uvRect del fondo en el eje x
        background.uvRect = new Rect(background.uvRect.x + finalSpeedBackground, 0f, 1f, 1f);
        //Lo mismo para las capas del mar
        seaFront.uvRect = new Rect(seaFront.uvRect.x + finalSpeedseaFront, 0f, 1f, 1f);
        seaMiddle.uvRect = new Rect(seaMiddle.uvRect.x + finalSpeedseaMiddle, 0f, 1f, 1f);
        seaBack.uvRect = new Rect(seaBack.uvRect.x + finalSpeedseaBack, 0f, 1f, 1f);
    }
}

