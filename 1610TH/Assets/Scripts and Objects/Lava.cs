using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;
using UnityEngine.SceneManagement;

public class Lava : MonoBehaviour
{

	
	
	// Update is called once per frame
	public void OnCollisionEnter(Collision player)
	{
		SceneManager.LoadScene("Game Over");
		
	}
}
