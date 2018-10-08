using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instancing : MonoBehaviour
{

	public GameObject Instance;
	
	// Use this for initialization
	void Update ()
	{
		if (Input.GetKeyDown(KeyCode.X)) //x key is assigned to GetKeyDown Function in Input Method to fire
		{
			Instantiate(Instance, transform.position, transform.rotation);
		}
	}
	
	
	
}
