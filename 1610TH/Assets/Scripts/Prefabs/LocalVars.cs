using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LocalVars : MonoBehaviour
{
	//variables are private by default unlees declared public or protected
	string Name;

	public void Call()
	{
		Name = "Bob";
		print(Name);
		//newName = "Error"; this is error because newName is local only to function below
	}

	public void Call(string newName) //seen only by this function when Name is private
	{
		print(newName);
		print(Name);
		//Name = "Fred";
		//newName = "Jim";
	}
}
