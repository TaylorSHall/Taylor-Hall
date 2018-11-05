using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.Events;

public class PowerupEnum : MonoBehaviour
{
	public PowerupStates.PowerStates ShulkState;
	public UnityEvent Null, Speed, Jump, Shield, Buster;
	
	// Update is called once per frame
	void Update () 
	{
		switch (ShulkState)
		{
			case PowerupStates.PowerStates.Null:
				break;

			case PowerupStates.PowerStates.Speed:
				print("Speed on!");
				break;

			case PowerupStates.PowerStates.Jump:
				print("Jump on!");
				break;

			case PowerupStates.PowerStates.Shield:
				print("Shield on!");
				break;

			case PowerupStates.PowerStates.Buster:
				print("Buster on!");
				break;
		}
	}
}
