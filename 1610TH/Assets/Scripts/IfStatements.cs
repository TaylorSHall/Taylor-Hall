using System.Collections;
using System.Collections.Generic;
using System.Runtime.Remoting.Channels;
using UnityEngine;

public class IfStatements : MonoBehaviour
{

	public bool LightOn;
	public string Password;
	public int A, B, C;

	public FloatData WizardPower, PawnPower;
	public NameID Lock, Key;
	
	void Update () 
	{
		if (Lock == Key)
		{
			print("Open Door");
		}
		
		if (WizardPower.Value > PawnPower.Value)
		{
			print("Wizard wins.");
		}
		
		if (LightOn)
		{
			print("The light is on.");
		}
		else
		{
			print("The light is off.");
		}

		if (Password == "OU812")
		{
			print("You are correct!");
		}
		else
		{
			print("You are incorrect!");
		}

		if (C == A + B)
		{
			print(C);
		}

		
	}
}
