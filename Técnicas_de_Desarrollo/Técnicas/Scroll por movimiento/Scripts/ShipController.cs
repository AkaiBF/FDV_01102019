using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipController : MonoBehaviour
{
    public float moveSpeed = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if((Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)) && GetComponent<Transform>().position.x > -7.2f)
        {
            GetComponent<Transform>().Translate(Vector2.left * moveSpeed * Time.deltaTime);
        }
        if((Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)) && GetComponent<Transform>().position.x < 7.2f)
        {
            GetComponent<Transform>().Translate(Vector2.right * moveSpeed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        this.GetComponent<Animator>().SetTrigger("Explosion");
    }
}
