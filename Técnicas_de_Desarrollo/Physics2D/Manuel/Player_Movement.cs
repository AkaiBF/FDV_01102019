using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movement : MonoBehaviour
{

    public bool canJump;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("left"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(-500 * Time.deltaTime, 0));
            gameObject.GetComponent<Animator>().SetBool("running", true);
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
        }

        if (Input.GetKey("right"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(500 * Time.deltaTime, 0));
            gameObject.GetComponent<Animator>().SetBool("running", true);
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
        }

        if (!Input.GetKey("left") && !Input.GetKey("right"))
        {
            gameObject.GetComponent<Animator>().SetBool("running", false);
        }

        if (Input.GetKeyDown("up") && canJump)
        {
            canJump = false;
            //El salto aplica una fuerza en un frame y no de forma continua.
            //No hace falta el Time.deltaTime.
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 200f));
        }
    }

    //Método para que solo salte una vez.
    //Detectamos cuando el collider del personaje se choca con el collider del suelo.
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Ground")
        {
            canJump = true;
        }

        if (collision.gameObject.name == "SpringCake")
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, 500f));
        }
    }

}

