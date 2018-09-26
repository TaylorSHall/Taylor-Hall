using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Powerup : ScriptableObject
{
	public FloatData Data; //outsideData is added to Data
	
	public void OnPowerUp(FloatData outsideData) //outsideData is local variable (inside function only)
	{
		outsideData.Value += Data.Value; //Powerup will add data to player's status
	}
	
}
