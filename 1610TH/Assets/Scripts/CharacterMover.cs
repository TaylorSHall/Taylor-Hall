using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMover : MonoBehaviour
{

	private CharacterController Controller;
	
	public float Gravity = 9.81f;
	public float JumpSpeed = 3.0f;
	private Vector3 position;
	// Use this for initialization
	void Start ()
	{
		Controller = GetComponent<CharacterController>();
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (Controller.isGrounded) //bool that is part of the character controller
		{
			if (Input.GetButton("Jump"))
			{
				position.y = JumpSpeed;
			}
			
		}
		position.y -= Gravity * Time.deltaTime; // regular rate in Unity in Sec
		Controller.Move(position * Time.deltaTime);
	}
}
