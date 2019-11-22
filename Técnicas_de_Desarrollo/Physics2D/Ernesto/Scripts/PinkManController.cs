using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinkManController : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float jumpForce = 10f;
    public Camera camera;
    public Canvas canva;
    public GameObject gameController;
    private bool touchingFloor;
    // Start is called before the first frame update
    void Start()
    {
        canva.gameObject.SetActive(false);
        touchingFloor = true;
    }

    // Update is called once per frame
    private void Update()
    {
        
    }
    void FixedUpdate()
    {
        if (!canva.gameObject.activeInHierarchy)
        {
            if (Input.GetAxis("Horizontal") != 0)
            {
                this.GetComponent<Animator>().SetBool("Running", true);
                if (Input.GetAxis("Horizontal") < 0)
                {
                    this.GetComponent<SpriteRenderer>().flipX = true;
                }
                else
                {
                    this.GetComponent<SpriteRenderer>().flipX = false;
                }
                this.GetComponent<Rigidbody2D>().AddForce(Vector3.right * Input.GetAxis("Horizontal") * moveSpeed);
            }
            else
            {
                this.GetComponent<Animator>().SetBool("Running", false);
            }
            if (Input.GetKeyDown(KeyCode.UpArrow) && touchingFloor)
            {
                this.GetComponent<Rigidbody2D>().AddForce(Vector2.up * jumpForce * Time.deltaTime);
                touchingFloor = false;
            }
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.contacts[0].normal == new Vector2(0, 1))
        {
            touchingFloor = true;
        }
        if(collision.gameObject.name == "ZoneOfDeath")
        {
            canva.gameObject.SetActive(true);
            this.transform.position = new Vector3(-5.49f, -1.15f, -6.39f);
            this.gameController.GetComponent<CGameController>().pause = true;   
        }
        if(collision.gameObject.name == "Resorte")
        {
            Vector2 direccion = this.GetComponent<Rigidbody2D>().velocity;
            Debug.Log(direccion);
            Vector2 reflejado = Vector2.Reflect(direccion, collision.contacts[0].normal);
            Debug.Log(collision.contacts[0].normal);
            Debug.Log(reflejado);
            this.GetComponent<Rigidbody2D>().velocity = reflejado;
        }
        
    }
}
