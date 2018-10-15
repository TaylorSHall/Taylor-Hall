using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerupID : MonoBehaviour
{
	public NameID Health, Money, Ammo, Swag;

	public void Update()
	{
		if (Money)
		{
			print("Picked up Money");
		}
		
		if (Health)
		{
			print("Picked up Health");
		}
		
		if (Ammo)
		{
			print("Picked up Ammo");
		}
		
		if(Swag)
		{
			print("Picked up Swag");
		}
	}
}
