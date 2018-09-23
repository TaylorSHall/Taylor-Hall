using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddMoney : MonoBehaviour
{

	public int Money = 20;
	
	// Use this for initialization
	public void AddMoreMoney (int money)
	{
		Money += money;
		//Money = Money + money;
	}
}
