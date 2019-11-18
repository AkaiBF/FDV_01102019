using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour 
{	//movimiento usando transform

	public bool canJump;
	
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{

		if (Input.GetKey("left"))
		{
			gameObject.transform.Translate(-5f * Time.deltaTime, 0, 0);
			gameObject.GetComponent<Animator>().SetBool("walking", true);
			gameObject.GetComponent<SpriteRenderer>().flipX = true;
		}
		
		if (Input.GetKey("right"))
		{
			gameObject.transform.Translate(5f * Time.deltaTime, 0, 0);
			gameObject.GetComponent<Animator>().SetBool("walking", true);
			gameObject.GetComponent<SpriteRenderer>().flipX = false;
		}

		if (!Input.GetKey("left") && !Input.GetKey("right"))
		{
			gameObject.GetComponent<Animator>().SetBool("walking", false);
		}

		ManageJump();

	}

	void ManageJump()
	{

		if (gameObject.transform.position.y <= 0)
		{
			canJump = true;
		}

		if (Input.GetKey("up") && canJump && gameObject.transform.position.y <= 0)
		{
			gameObject.transform.Translate(0, 80f * Time.deltaTime, 0);
		}
		
		else 
		{
			canJump = false;

			if (gameObject.transform.position.y > 0)
			{
				gameObject.transform.Translate(0, -1f * Time.deltaTime, 0);
			}
		}
	}
}
