using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapiController : MonoBehaviour
{
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            anim.SetBool("Front", true);
        }
        if(Input.GetKeyDown(KeyCode.S))
        {
            anim.SetBool("Front", false);
        }
    }
}
