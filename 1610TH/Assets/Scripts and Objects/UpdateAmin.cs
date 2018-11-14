using UnityEngine;

public class UpdateAmin : MonoBehaviour
{


	private Animator anims;

	public float Speed;
	// Use this for initialization
	void Start ()
	{
		anims = GetComponent<Animator>();
	}
	
	// Update is called once per frame
	void Update () 
	{
		anims.SetFloat("Speed", Speed);
	}
}
