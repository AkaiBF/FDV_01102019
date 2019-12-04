using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaskGuyController : MonoBehaviour
{
    public float jumpforce = 20.0f;
    public float moveSpeed = 15.0f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            this.GetComponent<Transform>().Translate(new Vector2(moveSpeed, 0));
        }
        if (Input.GetKey(KeyCode.A))
        {
            this.GetComponent<Transform>().Translate(new Vector2(-moveSpeed, 0));
        }
        if (Input.GetKeyDown(KeyCode.W))
        {
            this.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpforce));
        }

    }
}
