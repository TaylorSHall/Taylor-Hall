using UnityEngine;
using UnityEngine.AI;

public class BasicAI : MonoBehaviour
{

	private NavMeshAgent agent;
	private Vector3 Center;
	public Transform Destination;
	void Start ()
	{
		agent = GetComponent<NavMeshAgent>();
	}
	
	void Update ()
	{
		if (Destination != null) agent.destination = Destination.position; //AI will go WHEREVER it's told to go
		//else if (Destination == null) agent.destination = 
	}
}
