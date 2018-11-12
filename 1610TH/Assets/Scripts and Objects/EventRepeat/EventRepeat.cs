using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Events;

public class EventRepeat : MonoBehaviour
{

	public UnityEvent[] OnRepeat;
	//public UnityEvent OnRepeat;
	//public UnityEvent OnRepeatTwo;
	public float Seconds = 2;
	private int i = 0;
	
	// Use this for initialization
	IEnumerator Start () //yielded, held, and stopped
	{
		while (true)
		{
			yield return new WaitForSeconds(Seconds);
			
			OnRepeat[i].Invoke();
			
			if (i < OnRepeat.Length - 1)
			{
				i++;
			}
			else
			{
				i = 0;
			}
		}
	}
	
}
