using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variabes : MonoBehaviour
{
	public bool IsAWizard;
	
	// without a number attatched to value name, the value is automaticaly 0 
	public int AmmoCount = 100;
	public int InventoryCount;
	// when using a decimal number, put an f at the end of number
	public float Health = 1.0f;
	public float Money;

	public string PlayerName;
	public string Team = "Wolves";

	public Vector3 Location;
	
	// Use this for initialization
	void Start ()
	{
		print(PlayerName);
		print("has");
		print("$"+Money);

		if (IsAWizard)
		{
			print("You're a Wizard, " + PlayerName + ".");
		}
	}
	
	// Update is called once per frame
	void Update ()
	{
		transform.position = Location;
	}
}
