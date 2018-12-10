using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.Events;

public class SwitchStatements : MonoBehaviour
{
	public string GameState;
	public UnityEvent Starting, Loading, Playing, Ending, Dying;
	
	// Update is called once per frame
	public void ChangeStates(string newState)
	{
		GameState = newState;
		RunStates();
	}
	void RunStates () //Command will loop either state because switch is in update
	{
		switch (GameState)
		{
			case "Starting":
				Starting.Invoke();
				break; //stop and get out of the switch block
			
			case "Loading":
				Loading.Invoke();
				break; //stop and get out of the switch block

			case "Dying":
				Dying.Invoke();
				break; //stop and get out of the switch block
			
			case "Playing":
				Playing.Invoke();
				break; //stop and get out of the switch block
			
			case "Ending":
				Ending.Invoke();
				break; //stop and get out of the switch block
		}
	}
}
