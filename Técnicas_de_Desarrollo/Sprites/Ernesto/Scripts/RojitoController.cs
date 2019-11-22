using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RojitoController : MonoBehaviour
{
    public float jumpforce = 20.0f;
    public float moveSpeed = 15.0f;
    Animator anim;
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        anim = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        bool walking = false;
        if(Input.GetKey(KeyCode.RightArrow)) {
            this.GetComponent<Transform>().Translate(new Vector2(moveSpeed, 0));
            anim.SetBool("walkState", true);
            walking = true;
        }
        if (Input.GetKey(KeyCode.LeftArrow)) {
            this.GetComponent<Transform>().Translate(new Vector2(-moveSpeed, 0));
            anim.SetBool("walkState", true);
            walking = true;
        }
        if(Input.GetKeyDown(KeyCode.Space))
        {
            this.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jumpforce));
        }
        if(!walking)
        {
            anim.SetBool("walkState", false);
        }
        Debug.Log((this.transform.position - target.transform.position).magnitude);
        if ((this.transform.position - target.transform.position).magnitude < 4)
        {
            target.GetComponent<Animator>().SetTrigger("On");
        }

    }
}
