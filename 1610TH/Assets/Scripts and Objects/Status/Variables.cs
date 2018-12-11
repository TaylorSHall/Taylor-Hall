using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{
	public bool IsAWizard;
	const int Swagcap = 100;
	
	// without a number attached to value name, the value is automatically 0 
	public int AmmoCount = 100;
	public int InventoryCount;

	public int Swag;
	// when using a decimal number, put an f at the end of number
	public float Health = 1.0f;
	public float Money;

	public string PlayerName;
	public GameObject Key;
	
	// Use this for initialization
	void Start ()
	{
		print(PlayerName);
		print("has");
		print("$"+Money);

		if (Swag >= Swagcap)
		{
			IsAWizard = true;
		}
		
		
		if (IsAWizard)
		{
			print("You're a Wizard, " + PlayerName + ".");
		}
		else //ELSE STATEMENT ADDITIONAL WORK
		{
			print(PlayerName + " is a muggle :(");
		}
	}
	
	// Update is called once per frame
	//void Update ()
	//{
	//	transform.position = Location;
	//}
}
