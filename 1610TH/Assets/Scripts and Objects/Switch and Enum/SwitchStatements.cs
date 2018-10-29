using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using UnityEngine.Events;

public class SwitchStatements : MonoBehaviour
{
	public GameStates.States GameState;
	public UnityEvent Starting, Loading, Playing, Ending, Dying;
	
	// Update is called once per frame
	void Update () //Command will loop either state because switch is in update
	{
		switch (GameState)
		{
			case GameStates.States.Starting:
				print("We are starting the Game.");
				break; //stop and get out of the switch block
			
			case GameStates.States.Loading:
				print("We are loading the Game.");
				break; //stop and get out of the switch block

			case GameStates.States.Dying:
				print("You are dead. Try the Game again.");
				break; //stop and get out of the switch block
			
			case GameStates.States.Playing:
				print("We are playing the Game.");
				break; //stop and get out of the switch block
			
			case GameStates.States.Ending:
				print("We are ending the Game. Game Over.");
				break; //stop and get out of the switch block
		}
	}
}
