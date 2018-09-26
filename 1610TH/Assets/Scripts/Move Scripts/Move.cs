using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour 
{

	// Use this for initialization
	//private void Update ()
	//{
		
	//}
	public CharacterController Character;
	
	public float Speed;
	public Vector3 MoveSpeed;
	public Vector3 RotateSpeed;
	
	// Update is called once per frame
	private void Update()
	{
		//Movement of object controlled by arrow keys
		MoveSpeed.x = Speed*Input.GetAxis("Horizontal");
		MoveSpeed *= Time.deltaTime;

		Character.Move(MoveSpeed);
	}
}
