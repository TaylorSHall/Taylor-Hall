using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class DestroyObject : MonoBehaviour {

	IEnumerator Start () 
	{
		yield return new WaitForSeconds(2);
		Destroy(gameObject);
	}

	private void OnCollisionEnter(Collision other)
	{
		Destroy(other.gameObject);
		Destroy(gameObject);
	}
}
