using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour 
{
	public CharacterController Character;
	
	public float Speed;
	public Vector2 MoveSpeed;
	public float JumpSpeed;
	public bool facingRight;
	
	// Update is called once per frame
	private void Update()
	{
		//Movement of object controlled by arrow keys
		MoveSpeed.x = Speed*Input.GetAxis("Horizontal");
		MoveSpeed *= Time.deltaTime;
		//Player Jumping
		if (Input.GetButton("Jump"))
		{
			MoveSpeed.y = JumpSpeed;
		}

		//if (MoveSpeed < 0.0f && facingRight == false)
		//{
		//	FlipPlayer ();
		//}
		
		//facingRight = 
		
		Character.Move(MoveSpeed);
	}
}
