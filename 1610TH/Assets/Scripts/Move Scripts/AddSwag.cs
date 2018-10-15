using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddSwag : MonoBehaviour
{
	public int Swag = 1;
	
	// Use this for initialization
	public void AddMoreSwag (int swag)
	{
		Swag += swag;
	}
	
}
